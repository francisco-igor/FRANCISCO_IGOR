using System.ComponentModel.DataAnnotations;

namespace FRANCISCO_IGOR.Models
{
    public class PagamentoComCheque : TipoDePagamento
    {
        [Display(Name = "Código do Banco")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Range(000, 999, ErrorMessage = "O campo {0} deve ter 3 caracteres")]
        public int Banco {get; set;}

        [Display(Name = "Nome do Banco")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(20)]
        public string NomeDoBanco {get; set;}
    }
}