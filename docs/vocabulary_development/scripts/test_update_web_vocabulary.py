import json
from pathlib import Path
import tempfile
import unittest
from unittest.mock import Mock, patch

import requests
import update_web_vocabulary as publisher


class PublisherTests(unittest.TestCase):
    def test_generated_json_preserves_multiline_and_final_description(self):
        with tempfile.TemporaryDirectory() as directory:
            path = Path(directory) / "source.json"
            path.write_text(json.dumps({"Nouns": [{"Name": "A", "Description": ["first", "second"]}],
                                        "Verbs": [{"Name": "Final", "Description": ["last"]}]}), encoding="utf-8")
            terms = publisher.load_terms(path)
        self.assertEqual([t.description for t in terms], ["first\nsecond", "last"])

    def test_wordpress_typographic_quotes_do_not_trigger_false_mismatches(self):
        term = publisher.Term("Equipment", "Noun", "")
        item = self.item(term)
        item["content"]["rendered"] = item["content"]["rendered"].replace("&#x27;", "&#8216;", 1).replace("&#x27;", "&#8217;", 1)
        self.assertTrue(publisher.matches(item, term, 46))

    def test_wordpress_typographic_dashes_preserve_description_equivalence(self):
        term = publisher.Term("Location", "Noun", "A location\n - some coordinates")
        item = self.item(term)
        item["content"]["rendered"] = item["content"]["rendered"].replace(" - some", " &#8211; some")
        self.assertTrue(publisher.matches(item, term, 46))

    def test_duplicate_source_names_fail(self):
        with tempfile.TemporaryDirectory() as directory:
            path = Path(directory) / "source.json"
            path.write_text(json.dumps({"Nouns": [{"Name": "A"}], "Verbs": [{"Name": "A"}]}))
            with self.assertRaises(ValueError):
                publisher.load_terms(path)

    @staticmethod
    def item(term, category=46):
        value = publisher.payload(term, category, "abc", "2026-10-19T14:00:00Z")
        return {"id": 10, "title": {"rendered": value["title"]},
                "content": {"rendered": value["content"]}, "status": "publish",
                "glossary-categories": [category]}

    def test_payload_escapes_html_and_preserves_multiline_unicode(self):
        term = publisher.Term("Tool", "Noun", '<script>x</script> & "a"\nnext Ω')
        item = self.item(term)
        self.assertIn("&lt;script&gt;", item["content"]["rendered"])
        self.assertNotIn("<script>", item["content"]["rendered"])
        self.assertTrue(publisher.matches(item, term, 46))

    def test_dates_do_not_trigger_unchanged_write(self):
        term = publisher.Term("Tool", "Noun", "description")
        client = Mock()
        item = self.item(term)
        item["modified_gmt"] = "1990-01-01T00:00:00"
        self.assertEqual(publisher.publish_one(client, term, item, 46, "new", "date"), "unchanged")
        client.request.assert_not_called()

    def test_existing_update_and_readback_mismatch(self):
        term = publisher.Term("Tool", "Noun", "new")
        client = Mock()
        old = self.item(publisher.Term("Tool", "Noun", "old"))
        client.request.return_value = self.item(term)
        self.assertEqual(publisher.publish_one(client, term, old, 46, "new", "date"), "updated")
        self.assertEqual(client.request.call_args.args, ("POST", "/wp/v2/glossary/10"))
        client.request.return_value = old
        with self.assertRaises(RuntimeError):
            publisher.publish_one(client, term, old, 46, "new", "date")

    def test_ambiguous_creation_is_read_back_without_second_post(self):
        term = publisher.Term("Tool", "Noun", "new")
        client = Mock()
        client.request.side_effect = [RuntimeError("timeout"), [self.item(term)]]
        self.assertEqual(publisher.publish_one(client, term, None, 46, "abc", "date"), "created")
        self.assertEqual([call.args[0] for call in client.request.call_args_list], ["POST", "GET"])

    def test_ambiguous_creation_not_found_fails(self):
        client = Mock()
        client.request.side_effect = [RuntimeError("timeout"), []]
        with self.assertRaises(RuntimeError):
            publisher.publish_one(client, publisher.Term("Tool", "Noun", "new"), None, 46, "abc", "date")

    @patch.object(publisher.time, "sleep")
    @patch.object(publisher.requests, "request")
    def test_get_retries_transient_failure_with_timeout_and_tls_validation(self, request, sleep):
        request.side_effect = [Mock(status_code=503), Mock(status_code=200, json=lambda: [])]
        self.assertEqual(publisher.WordPress("https://example.test").request("GET", "/wp/v2/glossary"), [])
        self.assertEqual(request.call_count, 2)
        self.assertEqual(request.call_args.kwargs["timeout"], (10, 45))
        self.assertNotIn("verify", request.call_args.kwargs)

    def test_all_existing_duplicate_descriptions_are_verified_and_repaired(self):
        term = publisher.Term("Tool", "Noun", "new")
        root = self.item(term)
        duplicate = self.item(publisher.Term("Tool", "Noun", "old"))
        duplicate["id"] = 11
        root["_duplicates"] = [duplicate]
        self.assertEqual(publisher.verify([term], {"Tool": root}, 46), ["Tool"])
        client = Mock()
        client.request.return_value = {**self.item(term), "id": 11}
        self.assertEqual(publisher.publish_one(client, term, root, 46, "abc", "date"), "updated")
        self.assertEqual(client.request.call_args.args, ("POST", "/wp/v2/glossary/11"))

    @patch.object(publisher.requests, "request", side_effect=requests.Timeout)
    def test_creation_timeout_is_not_retried(self, request):
        with self.assertRaises(RuntimeError):
            publisher.WordPress("https://example.test").request("POST", "/wp/v2/glossary", data={})
        self.assertEqual(request.call_count, 1)

    @patch.object(publisher.requests, "request", return_value=Mock(status_code=202, json=lambda: {"code": "unexpected_status", "message": "not completed"}))
    def test_accepted_or_challenge_response_is_not_success(self, request):
        with self.assertRaises(RuntimeError):
            publisher.WordPress("https://example.test").request("POST", "/wp/v2/glossary", data={})

    def test_verification_rejects_missing_wrong_content_category_and_status(self):
        term = publisher.Term("Tool", "Noun", "expected")
        self.assertEqual(publisher.verify([term], {}, 46), ["Tool"])
        item = self.item(publisher.Term("Tool", "Noun", "wrong"))
        self.assertEqual(publisher.verify([term], {"Tool": item}, 46), ["Tool"])
        item = self.item(term, 47)
        self.assertFalse(publisher.matches(item, term, 46))
        item = self.item(term)
        item["status"] = "draft"
        self.assertFalse(publisher.matches(item, term, 46))

    def test_pagination_is_stable_and_existing_duplicate_urls_are_preserved(self):
        client = publisher.WordPress("https://example.test")
        item = self.item(publisher.Term("Tool", "Noun", "x"))
        duplicate = {**item, "id": 11}
        with patch.object(client, "request", return_value=[item, duplicate]) as request:
            glossary = client.glossary(46)
        self.assertEqual(glossary["Tool"]["id"], 10)
        self.assertEqual(glossary["Tool"]["_duplicates"][0]["id"], 11)
        self.assertEqual(request.call_args.kwargs["params"]["orderby"], "id")


if __name__ == "__main__":
    unittest.main()
