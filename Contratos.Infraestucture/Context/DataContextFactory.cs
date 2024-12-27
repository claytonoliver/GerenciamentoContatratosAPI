using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Contratos.Infraestucture.Context
{
    public class DataContextFactory : IDesignTimeDbContextFactory<DataContext>
    {
        public DataContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DataContext>();
            optionsBuilder.UseSqlServer("Data Source=GAME-PC\\SQLEXPRESS;Initial Catalog=ContractsManager_API;Integrated Security=True;Trust Server Certificate=True");

            return new DataContext(optionsBuilder.Options);
        }
    }
}
