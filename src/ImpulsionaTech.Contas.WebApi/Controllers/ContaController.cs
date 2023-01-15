using Microsoft.AspNetCore.Mvc;

namespace ImpulsionaTech.Contas.WebApi.Controllers
{
  [Route("[controller]")]
    public class ContaController : Controller
    {
        private readonly ILogger<ContaController> _logger;

        public ContaController(ILogger<ContaController> logger)
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
