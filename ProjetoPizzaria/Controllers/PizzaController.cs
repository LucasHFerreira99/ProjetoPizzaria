using Microsoft.AspNetCore.Mvc;
using ProjetoPizzaria.Dto;
using ProjetoPizzaria.Models;
using ProjetoPizzaria.Services.Pizza;

namespace ProjetoPizzaria.Controllers
{
    public class PizzaController : Controller
    {
        private readonly IPizzaInterface _pizzaInterface;

        public PizzaController(IPizzaInterface pizzaInterface)
        {
            _pizzaInterface = pizzaInterface;
        }
        public async Task<IActionResult> Index()
        {
            var pizzas = await _pizzaInterface.GetPizzas();
            return View(pizzas);
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        public async Task<IActionResult> Editar(int Id)
        {
            var pizza = await _pizzaInterface.GetPizzaPorId(Id);
            return View(pizza);
        }

        public async Task<IActionResult> Remover(int id)
        {
            var pizza = await _pizzaInterface.RemoverPizza(id);
            return RedirectToAction("Index", "Pizza");
        }

        public async Task<IActionResult> Detalhes(int id)
        {
            var pizza = await _pizzaInterface.GetPizzaPorId(id);
            return View(pizza);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Cadastrar(PizzaCriacaoDto pizzaCriacaoDto, IFormFile foto)
        {
            if(ModelState.IsValid)
            {
                var pizza = await _pizzaInterface.CriarPizza(pizzaCriacaoDto, foto);
                return RedirectToAction("Index", "Pizza");
            }
            else
            {
                return View(pizzaCriacaoDto);
            }
        }

        [HttpPost] 
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Editar(PizzaModel pizzaModel, IFormFile? foto)
        {
            if (ModelState.IsValid)
            {
                var pizza = await _pizzaInterface.EditarPizza(pizzaModel, foto);
                return RedirectToAction("Index", "Pizza");
            }
            else
            {
                return View(pizzaModel);
            }
        }
        

    }
}
