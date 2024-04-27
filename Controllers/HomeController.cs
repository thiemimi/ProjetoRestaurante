using Microsoft.AspNetCore.Mvc;
using rm551478.Models;
using System.Diagnostics;

namespace rm551478.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Endereco endereco = new Endereco(1, "Bela Vista", 160, "apto 90");
            Cliente cliente = new Cliente("Renata", "3432452352", endereco);
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
