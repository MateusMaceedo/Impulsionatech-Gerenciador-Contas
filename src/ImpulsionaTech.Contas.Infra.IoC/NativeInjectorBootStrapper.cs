using Equinox.Infra.CrossCutting.Bus;
using Microsoft.Extensions.DependencyInjection;
using NetDevPack.Mediator;

namespace ImpulsionaTech.Contas.Infra.IoC
{
  public static class NativeInjectorBootStrapper
  {
    public static void RegisterServices(IServiceCollection services)
    {
       // Domain Bus (Mediator)
       services.AddScoped<IMediatorHandler, InMemoryBus>();
    }
  }
}
