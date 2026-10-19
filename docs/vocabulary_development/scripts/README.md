# Vocabulary publishing scripts

`update_web_vocabulary.py` publishes nouns and verbs from the authoritative generated
`auto-generated/json/DWISVocabulary.json`. It preserves complete multiline descriptions,
escapes source prose as HTML text, compares the actual published description and category,
and skips unchanged terms regardless of commit or WordPress timestamps. Source commit
provenance remains attached to each updated entry.

Configure `SOURCE_PATH` as the generated Markdown directory (the JSON source is in its
sibling `json` directory), `WORDPRESS_URL`, `WORDPRESS_USER` and
`WORDPRESS_APPLICATION_PASSWORD`. `WORDPRESS_USE_REST_ROUTE` defaults to true.
Credentials must come from the environment or the workflow secret, never source files.
TLS verification is enabled; local installations behind an enterprise proxy must use
an approved CA bundle or the operating system's existing trusted certificate store.

Requests have a 10-second connection timeout and a 45-second read timeout. GET requests
and replacement writes to known IDs retry transient failures at most three times.
Creation requests are never blindly retried after an ambiguous failure: the publisher
looks up the exact existing title first, avoiding duplicate creation. HTTP 202 or an
HTML challenge response is not treated as a successful WordPress write.

Only the Vocabulary category is managed. Existing duplicate titles are reported and
all their descriptions are repaired in place; their URLs are retained. Unrelated and
obsolete entries are retained. Bulk deletion is not supported. Changes are incremental,
so an interrupted run can be repeated safely; publication is not one site-wide transaction.
`FORCE_UPDATE=true` deliberately rewrites all current source terms. `WORDPRESS_WORKERS`
controls concurrent independent term updates (default 2, allowed range 1 through 4).

Every run reads the glossary back and checks every source term, including duplicate
copies, for matching description, publication state and category. Failed writes or
readback mismatches fail the process. `REPORT_PATH` chooses the JSON report location.
`VERIFY_ONLY=true` performs a public read-only audit without requiring publishing
credentials or modifying entries.

Run focused tests from this folder after installing `requirements.txt`:

```shell
python -m unittest -v test_update_web_vocabulary.py
```

The GitHub workflow runs these tests before publication, exposes unbuffered progress,
serializes glossary publishers, has a 45-minute job limit and uploads the verification
report even when publication fails. It runs after successful vocabulary generation or
manual dispatch. A missing publishing secret is an error, rather than a successful no-op.
