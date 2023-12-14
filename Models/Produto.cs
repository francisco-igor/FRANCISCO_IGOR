using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FRANCISCO_IGOR.Models
{
    public class Produto
    {
        public int Id {get; set;}

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "O campo {0} deve ter entre 3 e 50 caracteres")]
        public string Nome {get; set;}

        [Display(Name = "Descrição")]
        public string? Descricao {get; set;}
        
        [Display(Name = "Preço")]
        [Column(TypeName = "decimal(10,2)")]
        [DataType(DataType.Currency)]
        public decimal? Preco {get; set;}

        public int? Quantidade {get; set;}

        [Display(Name = "Marca")]
        [ForeignKey("Marca")]
        public int MarcaId {get; set;}

        public virtual Marca? Marca {get; set;}
        public virtual ICollection<Item>? Itens {get; set;}
    }
}