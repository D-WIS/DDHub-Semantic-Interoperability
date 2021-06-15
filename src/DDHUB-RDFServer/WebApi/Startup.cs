using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using DDHubServer;

namespace WebApi
{
    public class Startup : StartupBase
    {
        public override void ConfigureServices(IServiceCollection services)
        {
            string model = @"C:\Users\beda\source\repos\D-WIS\DDHub-Semantic-Interoperability\model\DDHub_Turtle.owl";
            services.AddSingleton<IDDHubServer, InMemoryDDHubServer>(sp =>InMemoryDDHubServer.CreateFromFile(model));

            services.AddCors(options => options.AddPolicy("Cors", builder =>
            {
                builder
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowCredentials()
                .AllowAnyHeader();
            }));


            services.AddMvc();

            // Register the Swagger generator, defining 1 or more Swagger documents
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo()
                {
                    Title = "DDHub API v1",
                    Version = "0.1",
                    Contact = new Microsoft.OpenApi.Models.OpenApiContact()
                    {
                        Email = "beda@norceresearch.no",
                        Name = "Benoît Daireaux"
                    },
                    Description = "Draft openAPI for DDHub"
                });
            });
        }

        public override void Configure(IApplicationBuilder app)
        {
            app.UseCors("Cors");
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "DDHub API v1");
            });

            app.UseMvc();
            System.Threading.Tasks.Task handler(HttpContext context) =>
                context.Response.WriteAsync("hello world. the server is running but no controllers are recognized.");
            app.Run(handler);
        }
    }
}