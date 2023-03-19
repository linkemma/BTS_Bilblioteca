using Microsoft.OpenApi.Models;

namespace ST.Api.Extensions
{
    public static class SwaggerExtensions
    {
        public static IServiceCollection AddSwagger(this IServiceCollection services)
        {
            var openApi = new OpenApiInfo
            {
                Title = "Libreria API",
                Version = "v1",
                Description = "Biblioteca Publica 2022",
                TermsOfService = new Uri("https://browsertravelsolutions.com/"),
                Contact = new OpenApiContact
                {
                    Name = "BROWSER TRAVEL SOLUCIONS",
                    Email = " lgordillo@browsertravelsolutions.com",
                    Url = new Uri("https://browsertravelsolutions.com/")
                },
                License = new OpenApiLicense
                {
                    Name = "CC BY-NC",
                    Url = new Uri("https://browsertravelsolutions.com/")
                }
            };
            services.AddSwaggerGen(x =>
            {
                openApi.Version = "v1";
                x.SwaggerDoc("v1", openApi);
                
            });
            return services;
        }
    }
}
