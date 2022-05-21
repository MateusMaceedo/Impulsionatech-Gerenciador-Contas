using System.IO;
using System.Reflection;
using Gerenciador.Transferencia.WebAPI.Modules.Common.FeatureFlags;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.PlatformAbstractions;
using Microsoft.FeatureManagement;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Gerenciador.Transferencia.WebAPI.Modules.Common.Swagger
{
    /// <summary>
    ///     Swagger Extensions.
    /// </summary>
    public static class SwaggerExtensions
    {
        private static string XmlCommentsFilePath
        {
            get
            {
                string basePath = PlatformServices.Default.Application.ApplicationBasePath;
                string fileName = typeof(Startup).GetTypeInfo().Assembly.GetName().Name + ".xml";
                return Path.Combine(basePath, fileName);
            }
        }
    }
}
