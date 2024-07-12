using Microsoft.AspNetCore.Mvc;
using ProjetoPizzaria.Models;
using System.Diagnostics;

namespace ProjetoPizzaria.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public IActionResult Index()
        {
            return View();
        }
    }
}
