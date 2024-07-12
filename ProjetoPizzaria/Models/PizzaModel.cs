using System.ComponentModel.DataAnnotations;
using System.Security.Principal;

namespace ProjetoPizzaria.Models
{
    public class PizzaModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Preencha o nome!")]
        public string Sabor { get; set; } = string.Empty;

        [Required(ErrorMessage = "Você deve selecionar uma foto!")]
        public string Capa { get; set; } = string.Empty;

        [Required(ErrorMessage = "Preencha a descrição!")]
        public string Descricao { get; set; } = string.Empty;
        public double Valor { get; set; }
    }
}
