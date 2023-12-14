using Microsoft.EntityFrameworkCore;

namespace FRANCISCO_IGOR.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) {}

        public DbSet<Cliente> Clientes {get; set;}
        public DbSet<Vendedor> Vendedores {get; set;}
        public DbSet<Transportadora> Transportadoras {get; set;}
        public DbSet<Pagamento> Pagamentos {get; set;}
        public DbSet<TipoDePagamento> TiposDePagamento {get; set;}
        public DbSet<PagamentoComCartao> PagamentosComCartao {get; set;}
        public DbSet<PagamentoComCheque> PagamentosComCheque {get; set;}
        public DbSet<NotaDeVenda> NotasDeVenda {get; set;}
        public DbSet<Marca> Marcas {get; set;}
        public DbSet<Produto> Produtos {get; set;}
        public DbSet<Item> Itens {get; set;}

        /*
        Tentativa de utilizar um controlador de sequência de códigos

        public static class Counter
        {
            private static int _counter = 0;

            public static int ProximoCodigo()
            {
                return _counter++;
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var proximoCodigoCartao = Counter.ProximoCodigo();
            var proximoCodigoCheque = Counter.ProximoCodigo();

            modelBuilder.Entity<TipoDePagamento>()
                .HasDiscriminator<string>("NomeTipoDePagamento")
                .HasValue<PagamentoComCartao>($"Cartão {proximoCodigoCartao}")
                .HasValue<PagamentoComCheque>($"Cheque {proximoCodigoCheque}");
        }
        */
    }
}
