using System.ComponentModel.DataAnnotations;

namespace FRANCISCO_IGOR.Models
{
    public class Transportadora
    {
        public int Id {get; set;}

        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "O campo {0} deve ter entre 3 e 50 caracteres")]
        public string Nome {get; set;}

        [StringLength(50, ErrorMessage = "O campo {0} deve ter no máximo 50 caracteres")]
        public string? Sede {get; set;}

        public virtual ICollection<NotaDeVenda>? NotasDeVenda {get; set;}
    }
}