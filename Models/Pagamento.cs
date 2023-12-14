using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FRANCISCO_IGOR.Models
{
    public class Pagamento
    {
        public int Id {get; set;}

        [Display(Name = "Data Limite")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [DataType(DataType.Date)]
        public DateTime DataLimite {get; set;}

        [Display(Name = "Preço")]
        [Column(TypeName = "decimal(10,2)")]
        [DataType(DataType.Currency)]
        public decimal Valor {get; set;}

        public bool Pago {get; set;}

        public virtual ICollection<NotaDeVenda>? NotasDeVenda {get; set;}
    }
}