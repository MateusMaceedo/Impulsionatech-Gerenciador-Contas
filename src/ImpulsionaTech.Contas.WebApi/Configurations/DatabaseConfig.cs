using Equinox.Infra.Data.Context;
using ImpulsionaTech.Contas.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Equinox.Services.Api.Configurations
{
  public static class DatabaseConfig
    {
        public static void AddDatabaseConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            services.AddDbContext<ContasContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            services.AddDbContext<EventStoreSqlContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
        }
    }
}
