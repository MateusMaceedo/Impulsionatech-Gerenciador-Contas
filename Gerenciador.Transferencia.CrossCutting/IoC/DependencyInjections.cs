using AutoMapper;
using Gerenciador.Transferencia.Application.DTos;
using Gerenciador.Transferencia.Application.Models.Request;
using Gerenciador.Transferencia.Repository.Repository;
using Gerenciador.Transferencia.Repository.Repository.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Gerenciador.Transferencia.CrossCutting.IoC
{
    public static class DependencyInjections
    {
        public static void AddRegisterServicesAplication(this IServiceCollection services, IConfiguration configuration)
        {
            // AutoMapper
            var config = new AutoMapper.MapperConfiguration(cfg =>
            {
                cfg.AllowNullCollections = true;
                cfg.CreateMap<TransferenciaRequest, TransferenciaRequestDto>()
                .ForMember(src => src.IdContaDestino, contadestino => contadestino.MapFrom(opt => opt.IdContaDestino))
                .ForMember(src => src.IdContaOrigem, contaorigem => contaorigem.MapFrom(opt => opt.IdContaOrigem))
                .ForMember(src => src.Valor, valor => valor.MapFrom(opt => opt.Valor));
            });

            IMapper mapper = config.CreateMapper();
            services.AddSingleton(mapper);

            // Applications
            services.AddScoped<ITransferenciaRepository, TransferenciaRepository>();
            // Domain Validations

            // Services

            // UoW

            // Repositories DynamoDB

            // Repositories Redis
            services.AddStackExchangeRedisCache(options =>
            {
                options.Configuration = configuration.GetConnectionString("Redis");
                options.InstanceName = "MITArq-";
            });

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
