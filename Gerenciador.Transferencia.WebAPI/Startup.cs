using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Gerenciador.Transferencia.Infra.Middleware;
using Microsoft.OpenApi.Models;

namespace Gerenciador.Transferencia.WebAPI
{
    /// <summary>
    ///     Startup.
    /// </summary>
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }

        /// <summary>
        ///     Configure dependencies from application.
        /// </summary>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Gerenciador de Transferencia", Version = "v1", });
            });
        }

        /// <summary>
        ///     Configure http request pipeline.
        /// </summary>
        public void Configure(
            IApplicationBuilder app, 
            IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseMiddleware(typeof(ErrorMiddleware));

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSwagger();

            app.UseSwaggerUI(opt =>
            {
                opt.SwaggerEndpoint("/swagger/v1/swagger.json", "Gerenciador de Transferencias V1");
            });
        }
    }
}
