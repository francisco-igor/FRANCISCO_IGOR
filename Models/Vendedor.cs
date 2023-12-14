using System.ComponentModel.DataAnnotations;

namespace FRANCISCO_IGOR.Models
{
    public class Vendedor
    {
        public int Id {get; set;}

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "O campo {0} deve ter entre 3 e 50 caracteres")]
        public string Nome {get; set;}

        [DataType(DataType.PhoneNumber)]
        public int? Contato {get; set;}

        public virtual ICollection<NotaDeVenda>? NotasDeVenda {get; set;}
    }
}