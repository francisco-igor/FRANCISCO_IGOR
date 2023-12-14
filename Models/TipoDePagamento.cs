using System.ComponentModel.DataAnnotations;

namespace FRANCISCO_IGOR.Models
{
    public class TipoDePagamento
    {
        public int Id {get; set;}

        [Display(Name = "Nome do Cobrado")]
        [Required(ErrorMessage = "O campo {0} do Cobrado é obrigatório")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "O campo {0} deve ter entre 3 e 50 caracteres")]
        public string NomeDoCobrado {get; set;}
        
        [Display(Name = "Informações Adicionais")]
        public string? InformacoesAdicionais {get; set;}

        public virtual ICollection<NotaDeVenda>? NotasDeVenda {get; set;}
    }
}