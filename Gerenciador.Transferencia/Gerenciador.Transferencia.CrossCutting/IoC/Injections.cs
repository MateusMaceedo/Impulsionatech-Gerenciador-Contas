using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace Gerenciador.Transferencia.CrossCutting.IoC
{
    public static class Injections
    {
        public static void AddRegisterServicesAplication(this IServiceCollection services)
        {
            // AutoMapper

            //Applications

            //Domain Validations

            //Services

            //UoW

            //MessageBroker
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
