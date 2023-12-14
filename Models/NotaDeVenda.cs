using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FRANCISCO_IGOR.Models
{
    public class NotaDeVenda
    {
        public int Id {get; set;}
        
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [DataType(DataType.Date)]
        public DateTime Data {get; set;}

        public TipoNotaDeVenda Tipo {get; set;}

        [Display(Name = "Cliente")]
        [ForeignKey("Cliente")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public int ClienteId {get; set;}

        [Display(Name = "Vendedor")]
        [ForeignKey("Vendedor")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public int VendedorId {get; set;}

        [Display(Name = "Transportadora")]
        [ForeignKey("Transportadora")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public int TransportadoraId {get; set;}

        [Display(Name = "Tipo De Pagamento")]
        [ForeignKey("TipoDePagamento")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public int TipoDePagamentoId {get; set;}

        [Display(Name = "Pagamento")]
        [ForeignKey("Pagamento")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public int PagamentoId {get; set;}

        public virtual Cliente? Cliente {get; set;}
        public virtual Vendedor? Vendedor {get; set;}
        public virtual Transportadora? Transportadora {get; set;}
        public virtual TipoDePagamento? TipoDePagamento {get; set;}
        public virtual Pagamento? Pagamento {get; set;}
        public virtual ICollection<Item>? Itens {get; set;}
    }
}