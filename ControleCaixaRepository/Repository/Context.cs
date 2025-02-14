using ControleCaixaDomain.Domain;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class Context : DbContext
    {
        public DbSet<Pedido> Pedido { get; set; }

        public Context(DbContextOptions<Context> options): base(options)
        {


        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            #region Dados          

            modelBuilder.Entity<Pedido>()
                .ToTable("Pedido")
                .Property(p => p.Descricao)
                .HasColumnName("descricao");

            modelBuilder.Entity<Pedido>()
               .ToTable("Pedido")
               .Property(p => p.DataPedido)
               .HasColumnName("dataPedido");

            modelBuilder.Entity<Pedido>()
               .ToTable("Pedido")
               .Property(p => p.Valor)
               .HasColumnName("valor");

            modelBuilder.Entity<Pedido>()
               .ToTable("Pedido")
               .Property(p => p.Lancamento)
               .HasColumnName("Lancamento");          

            #endregion
        }

    }
}
