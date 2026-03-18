using Microsoft.EntityFrameworkCore;
using ProyectoWebScrub.Models;

namespace ProyectoWebScrub.Data
{
    public class TiendaContext : DbContext
    {
        public TiendaContext(DbContextOptions<TiendaContext> options)
            : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }
    }
}