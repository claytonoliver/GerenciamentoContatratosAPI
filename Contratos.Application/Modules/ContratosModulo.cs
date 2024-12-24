using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Contratos.Infraestucture.Context;
using Contratos.Infraestucture.Repositories;
using Contratos.Shared.Common.Interfaces;

namespace Contracts.Application.Modules
{
    public static class ContratosModulo
    {
        public static IServiceCollection AddContratosModulo(this IServiceCollection services)
        {
            // Registra o DbContext
            services.AddDbContext<ContratosDbContext>(options =>
                options.UseSqlServer("Data Source=GAME-PC\\SQLEXPRESS;Initial Catalog=ContractsManager_API;Integrated Security=True;Trust Server Certificate=True"));

            // Registra o repositório
            services.AddScoped<IContratoRepository, ContratosRepository>();

            return services;
        }
    }
}
