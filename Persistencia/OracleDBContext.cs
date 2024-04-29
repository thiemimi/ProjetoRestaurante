using Microsoft.EntityFrameworkCore;
using rm551478.Models;

namespace rm551478.Persistencia
{
    public class OracleDBContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<ItemPedido> ItensPedido { get; set; }
        public DbSet<Prato> Pratos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

        public OracleDBContext(DbContextOptions<OracleDBContext> options) : base(options)
        {

        }
         

    }
}
