using Gerenciador.Transferencia.Application.DTos;
using Gerenciador.Transferencia.Application.Interfaces;
using Gerenciador.Transferencia.WebAPI.Controllers.Base;
using Microsoft.AspNetCore.Mvc;

namespace Gerenciador.Transferencia.WebAPI.Controllers.v1
{
    /// <summary>
    /// Customer
    /// </summary>
    //[Authorize("Bearer")]
    [ApiVersion("1")]
    [Route("api/[controller]/{version}")]
    [ApiController]
    public class TransferenciaController : BaseController<TransferenciaRequestDto, int>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="appService"></param>
        public TransferenciaController(ITransferenciaUseCaseAsync appService) : base(appService) {}
    }
}
