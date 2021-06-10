using Microsoft.AspNetCore.Mvc;
using InMemoryDDHubServer;
namespace WebApi
{
    public class MyController : ControllerBase
    {
        private InMemoryDDHubServer.InMemoryDDHubServer _server;

        public MyController()
        {
            _server = InMemoryDDHubServer.InMemoryDDHubServer.CreateFromFile(@"C:\Users\beda\source\repos\D-WIS\DDHub-Semantic-Interoperability\model\DDHub_Turtle.owl");
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

        [HttpGet("graph")]
        public IActionResult GetGraph()
        {
            string graph = _server.Serialize();
            if (!string.IsNullOrEmpty(graph))
            {
                return Ok(graph);
            }
            else return base.NotFound();
        }

    }
}