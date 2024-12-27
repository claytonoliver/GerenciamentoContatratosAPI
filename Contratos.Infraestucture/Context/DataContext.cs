using Contratos.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Contratos.Infraestucture.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<ContratoModel> Contratos { get; set; }
        public DbSet<UsuarioModel> Usuarios { get; set; }
    }
}
