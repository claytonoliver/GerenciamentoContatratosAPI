using Contratos.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Contratos.Infraestucture.Context
{
    public class ContratosDbContext : DbContext
    {
        public ContratosDbContext(DbContextOptions<ContratosDbContext> options) : base(options)
        {
        }

        public DbSet<ContratoModel> Contratos { get; set; }
    }
}
