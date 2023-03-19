using FluentValidation.AspNetCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ST.Application.Interfaces;
using ST.Application.Services;
using System.Reflection;

namespace ST.Application.Extensions
{
    public static class InjecionExtensions
    {
        public static IServiceCollection AddInjectionApplication(this IServiceCollection services,
                                                                        IConfiguration configuration)
        {
            services.AddSingleton(configuration);
            services.AddFluentValidation(options =>
            {
                options.RegisterValidatorsFromAssemblies(AppDomain.CurrentDomain
                                                                  .GetAssemblies()
                                                                  .Where(p => !p.IsDynamic));
            });
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            services.AddScoped<ILibroApplication, LibrosApplication>();
            return services;
        }
    }
}
