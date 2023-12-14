using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FRANCISCO_IGOR.Models
{
    public class Item
    {
        public int Id {get; set;}
        
        [Display(Name = "Preço")]
        [Column(TypeName = "decimal(10,2)")]
        [DataType(DataType.Currency)]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public decimal Preco {get; set;}

        public int? Percentual {get; set;}

        public int? Quantidade {get; set;}

        [Display(Name = "Produto")]
        [ForeignKey("Produto")]
        public int ProdutoId {get; set;}

        [Display(Name = "Nota de Venda")]
        [ForeignKey("NotaDeVenda")]
        public int NotaDeVendaId {get; set;}

        public virtual Produto? Produto {get; set;}
        public virtual NotaDeVenda? NotaDeVenda {get; set;}
    }
}