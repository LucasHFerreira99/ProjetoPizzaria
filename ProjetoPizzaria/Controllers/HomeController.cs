using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ProjetoPizzaria.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
