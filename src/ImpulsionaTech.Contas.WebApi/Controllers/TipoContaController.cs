using Microsoft.AspNetCore.Mvc;

namespace ImpulsionaTech.Contas.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TipoContaController : Controller
    {
        private readonly ILogger<TipoContaController> _logger;

        public TipoContaController(ILogger<TipoContaController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}
