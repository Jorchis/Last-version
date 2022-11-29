using Last_version.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Last_version.Controllers
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
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Quees()
        {
            return View("Areas/Identity/Pages/Quees.cshtml");
        }
        public IActionResult Quienfue()
        {
            return View("Areas/Identity/Pages/Quienfue.cshtml");
        }
        public IActionResult Galeria()
        {
            return View("Areas/Identity/Pages/Galeria.cshtml");
        }
        public IActionResult Espejos()
        {
            return View("Areas/Identity/Pages/Espejos.cshtml");
        }
        public IActionResult Electronica()
        {
            return View("Areas/Identity/Pages/Electronica.cshtml");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}