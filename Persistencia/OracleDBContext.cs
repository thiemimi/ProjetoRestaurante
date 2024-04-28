using Microsoft.EntityFrameworkCore;
using rm551478.Models;

namespace rm551478.Persistencia
{
    public class OracleDBContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Funcionário> Funcionarios { get; set; }

    }
}
