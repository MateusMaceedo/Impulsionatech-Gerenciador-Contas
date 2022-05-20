using Gerenciador.Transferencia.Repository.Repository;
using Gerenciador.Transferencia.Repository.Repository.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Gerenciador.Transferencia.CrossCutting.IoC
{
    public static class DependencyInjections
    {
        public static void AddRegisterServicesAplication(this IServiceCollection services)
        {
            // AutoMapper

            // Applications
            services.AddScoped<ITransferenciaRepository, TransferenciaRepository>();
            // Domain Validations

            // Services

            // UoW

            // Repositories DynamoDB

            // Repositories Redis
            //services.AddScoped<ICustomerRedisRepository, CustomerRedisRepository>();
            //services.AddScoped<IProductRedisRepository, ProductRedisRepository>();
            //services.AddScoped<IOrderRedisRepository, OrderRedisRepository>();

            // MessageBroker
            //services.AddScoped<IMediatorHandler, KafkaServiceBusQueue>();
        }

        public static void SetSecurity(this IServiceCollection services, IConfiguration configuration)
        {
            //var tokenConfigurations = new TokenConfiguration();
            //var signingConfigurations = new SigningConfigurations();

            //new ConfigureFromConfigurationOptions<TokenConfiguration>(
            //    configuration.GetSection("TokenConfigurations")
            //)
            //.Configure(tokenConfigurations);
        }
    }
}
