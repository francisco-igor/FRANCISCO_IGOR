using System.ComponentModel.DataAnnotations;

namespace FRANCISCO_IGOR.Models
{
    public class Cliente
    {
        public int Id {get; set;}

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "O campo {0} deve ter entre 3 e 50 caracteres")]
        public string Nome {get; set;}

        [DataType(DataType.PhoneNumber)]
        public int? Contato {get; set;}

        [Display(Name = "Endereço")]
        [StringLength(50, ErrorMessage = "O campo {0} deve ter no máximo 50 caracteres")]
        public string? Endereco {get; set;}

        public virtual ICollection<NotaDeVenda>? NotasDeVenda {get; set;}
    }
}