using Microsoft.AspNetCore.Mvc;

namespace ImpulsionaTech.Contas.WebApi.Controllers
{
  [Route("[controller]")]
    public class MovimentacaoBancariaController : Controller
    {
        private readonly ILogger<MovimentacaoBancariaController> _logger;

        public MovimentacaoBancariaController(ILogger<MovimentacaoBancariaController> logger)
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
