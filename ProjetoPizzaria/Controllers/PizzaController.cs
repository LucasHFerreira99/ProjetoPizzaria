using Microsoft.AspNetCore.Mvc;

namespace ProjetoPizzaria.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
