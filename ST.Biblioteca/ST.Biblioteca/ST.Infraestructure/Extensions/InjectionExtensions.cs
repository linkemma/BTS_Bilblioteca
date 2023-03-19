using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ST.Infraestructure.Persistencies.Context;
using ST.Infraestructure.Persistencies.Interfaces;
using ST.Infraestructure.Persistencies.Repositories;

namespace ST.Infraestructure.Extensions
{
    public static class InjectionExtensions
    {
        public static IServiceCollection AddInjectionInfraestructure(this IServiceCollection services,
                                                                            IConfiguration configuration)
        {
            var assembly = typeof(BD_Browser_TravelContext).Assembly.FullName;

            services.AddDbContext<BD_Browser_TravelContext>(options => options.UseSqlServer(
                configuration.GetConnectionString("POSConnection"), b => b.MigrationsAssembly(assembly)),
                ServiceLifetime.Transient);
            services.AddTransient<IUnityOfWork, UnitOfWork>();
            services.AddScoped<ILibrosRepositories, LibrosRepositories>();

            return services;

        }
    }
}
