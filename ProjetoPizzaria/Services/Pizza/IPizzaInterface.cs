using ProjetoPizzaria.Dto;
using ProjetoPizzaria.Models;

namespace ProjetoPizzaria.Services.Pizza
{
    public interface IPizzaInterface
    {
        Task<PizzaModel> CriarPizza(PizzaCriacaoDto pizzaCriacaoDto, IFormFile foto);
        Task<List<PizzaModel>> GetPizzas();
        Task<PizzaModel> GetPizzaPorId(int id);
        Task<PizzaModel> EditarPizza(PizzaModel pizza,  IFormFile? foto);
    }
}
