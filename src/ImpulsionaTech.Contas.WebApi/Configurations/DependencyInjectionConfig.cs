using System;
using ImpulsionaTech.Contas.Infra.IoC;
using Microsoft.Extensions.DependencyInjection;

namespace Equinox.Services.Api.Configurations
{
    public static class DependencyInjectionConfig
    {
        public static void AddDependencyInjectionConfiguration(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            NativeInjectorBootStrapper.RegisterServices(services);
        }
    }
}
