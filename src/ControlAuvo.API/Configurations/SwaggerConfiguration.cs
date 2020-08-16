using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace ControlAuvo.API.Configurations
{
    public static class SwaggerConfiguration
    {
        public static void AddSwaggerConf(this IServiceCollection services)
        {
            services.AddSwaggerGen(c => {

                c.SwaggerDoc("v1",
                    new OpenApiInfo
                    {
                        Title = "Controle de ponto Auvo",
                        Version = "v1",
                        Description = "Desafio Controle de ponto Auvo",
                        Contact = new OpenApiContact
                        {
                            Name = "Nascimento, Daniel Rodrigues do",
                            Url = new Uri("https://github.com/daniel-rn")
                        }
                    });
            });
        }

        public static void UseSwaggerConf(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c => {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Desafio Controle de ponto Auvo");
            });
        }
    }
}
