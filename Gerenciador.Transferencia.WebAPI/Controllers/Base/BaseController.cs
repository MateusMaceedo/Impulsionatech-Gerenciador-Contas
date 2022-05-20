using Gerenciador.Transferencia.Application.DTos;
using Gerenciador.Transferencia.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;

namespace Gerenciador.Transferencia.WebAPI.Controllers.Base
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="Tid"></typeparam>
    public abstract class BaseController<T, Tid> : ControllerBase
        where T : BaseDTOEntity<Tid>
    {
        private readonly Stopwatch sw;
        /// <summary>
        /// 
        /// </summary>
        protected readonly IAppService<T, Tid> _appService;
        private ITransferenciaUseCaseAsync appService;

        ///<Summary>
        /// Constructor BaseGetController
        ///</Summary>
        protected BaseController(IAppService<T, Tid> appService)
        {
            _appService = appService;

            sw = new Stopwatch();
        }

        protected BaseController(ITransferenciaUseCaseAsync appService)
        {
            this.appService = appService;
        }

        /// <summary>
        /// Retorna a lista do objeto com os parâmetros de Tranferencia, Request para API de Contas e Clientes        
        /// </summary>
        //[ApiExplorerSettings(IgnoreApi = true)]
        [Authorize("Bearer")]
        [HttpGet]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public virtual async Task<IActionResult> GetAll()
        {
            sw.Start();

            var retorno = await _appService.GetAll();

            sw.Stop();

            return retorno.Any()
                ? Ok(new
                {
                    success = true,
                    data = retorno,
                    tempoProcessamento = TempoProcessamento(sw)
                })
                : (IActionResult)NoContent();
        }

        private string TempoProcessamento(Stopwatch stopwatch)
        {
            return $"{TimeSpan.FromMilliseconds(stopwatch.ElapsedMilliseconds).Seconds} segundos e " +
                        $"{TimeSpan.FromMilliseconds(stopwatch.ElapsedMilliseconds).Milliseconds} milessegundos";
        }
    }
}
