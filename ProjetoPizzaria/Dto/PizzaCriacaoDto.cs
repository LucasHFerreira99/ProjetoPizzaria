using System.ComponentModel.DataAnnotations;

namespace ProjetoPizzaria.Dto
{
    public class PizzaCriacaoDto
    {
        [Required(ErrorMessage = "Preencha o nome!")]
        public string Sabor { get; set; } = string.Empty;

        [Required(ErrorMessage = "Você deve selecionar uma foto!")]
        public string Capa { get; set; } = string.Empty;

        [Required(ErrorMessage = "Preencha a descrição!")]
        public string Descricao { get; set; } = string.Empty;

        [Required(ErrorMessage = "Preencha a descrição!")]
        public double Valor { get; set; }
    }
}
