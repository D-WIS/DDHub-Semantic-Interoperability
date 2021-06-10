using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace WebApi
{
    public class Startup : StartupBase
    {
        public override void ConfigureServices(IServiceCollection services)
        {
            services.AddMvcCore();


           
        }

        public override void Configure(IApplicationBuilder app)
        {
            app.UseMvc();         

            System.Threading.Tasks.Task handler(HttpContext context) =>
                context.Response.WriteAsync("hello world. the server is running but no controllers are recognized.");
            app.Run(handler);
        }
    }
}