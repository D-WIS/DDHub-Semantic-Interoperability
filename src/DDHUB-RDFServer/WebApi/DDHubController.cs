using Microsoft.AspNetCore.Mvc;
using DDHubServer;

namespace WebApi
{
    public class DDHubController : ControllerBase
    {
        private DDHubServer.IDDHubServer _server;

        public DDHubController(DDHubServer.IDDHubServer server)
        {
            _server = server;
            if (_server == null)
            {
                _server = DDHubServer.InMemoryDDHubServer.CreateFromFile(@"C:\Users\beda\source\repos\D-WIS\DDHub-Semantic-Interoperability\model\DDHub_Turtle.owl");
            }
        }

        [HttpGet("/")]
        public IActionResult Root()
        {
            return new ContentResult()
            {
                Content = "<html><head></head><body><form method=\"post\"><input name=\"data\"><button value=\"submit\">submit</button></form> hello from the controller </body></html>",
                ContentType = "text/html", 
            };
        }

        [HttpPost("/")]
        public IActionResult Root(string data)
        {
            if (_server.GetQueryResults(data, out string results))
            {           
                return Ok(results);
            }
            else
            {
                return base.BadRequest("Nope...");
            }
        }

        [HttpGet("graph/")]
        public IActionResult GetGraph()
        {
            if (_server.GetGraph(out string results))
            {
                return Ok(results);
            }
            else
            {
                return base.NotFound(results);
            }
        }

        [HttpGet("graph/{type}")]
        public IActionResult GetGraph(string type)
        {
            string query = "CONSTRUCT { ?s } WHERE {?s :SubClassOf " + type +"}";

            if (_server.GetQueryResults(query, out string results))
            {
                return Ok(results);
            }
            else
            {
                return base.BadRequest(results);
            }
        }

        [HttpGet("query/")]
        public IActionResult GetQueryResult(string data)
        {
            if (_server.GetQueryResults(data, out string results))
            {
                return Ok(results);
            }
            else
            {
                return base.BadRequest(results);
            }
        }

    }
}