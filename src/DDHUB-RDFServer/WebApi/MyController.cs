using Microsoft.AspNetCore.Mvc;

namespace WebApi
{
    public class MyController : ControllerBase
    {
        [HttpGet("/")]
        public IActionResult Root()
        {
            return new ContentResult()
            {
                Content = "<html><head></head><body><form method=\"post\"><input name=\"data\"><button value=\"submit\">submit</button></form> hello from the controller </body></html>",
                ContentType = "text/html"
            };
        }

        [HttpPost("/")]
        public IActionResult Root(string data)
        {
            return Ok("hello you added this data: " + data);
        }
    }
}