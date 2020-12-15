using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Simplifique.Domain.Interfaces;
using Simplifique.Infra.Repository;
using System.Diagnostics.CodeAnalysis;

namespace Simplifique.Infra
{
    [ExcludeFromCodeCoverage]
    public static class ServicesExtensions
    {
        public static void AddInfraDataSqlServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<SimplifiqueContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("Sql")).EnableSensitiveDataLogging());

            services.AddScoped<IAnunciarRepository, AnunciarRepository>();
            services.AddScoped<IAnuncioRepository, AnuncioRepository>();
            services.AddScoped<ICadastroRepository, CadastroRepository>();
            services.AddScoped<ILoginRepository, LoginRepository>();
            services.AddScoped<ICategoriaRepository, CategoriaRepository>();
            services.AddScoped<SimplifiqueContext>();

        }
    }
}
