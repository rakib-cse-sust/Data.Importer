using Application.Contracts.Infrastructure;
using Infrastructure;
using Infrastructure.Infrastructure;
using Infrastructure.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Web.API.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureMSSqlContext(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config["MSSqlconnection:ConnectionString"];

            services.AddDbContext<RepositoryContext>(options => options.UseSqlServer(
                connectionString, b => b.MigrationsAssembly("Web.API")));
        }

        public static void ConfigureRepositoryWrapper(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
        }

        public static void AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddTransient<ICsvImporter, CsvImporter>();
        }
    }
}