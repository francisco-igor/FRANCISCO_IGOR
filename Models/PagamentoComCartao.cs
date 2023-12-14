using System.ComponentModel.DataAnnotations;

namespace FRANCISCO_IGOR.Models
{
    public class PagamentoComCartao : TipoDePagamento
    {
        [Display(Name = "Número do Cartão")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string NumeroDoCartao {get; set;}

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(20)]
        public string Bandeira {get; set;}
    }
}