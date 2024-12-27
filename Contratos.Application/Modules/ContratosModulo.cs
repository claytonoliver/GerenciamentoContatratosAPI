using Contratos.Application.Commands.CriarContrato;
using Contratos.Application.Handlers;
using Contratos.Application.Services;
using Contratos.Infraestucture.Context;
using Contratos.Infraestucture.Repositories;
using Contratos.Shared.Common.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Contracts.Application.Modules
{
    public static class ContratosModulo
    {
        public static IServiceCollection AddContratosModulo(this IServiceCollection services)
        {
            // Registra o DbContext
            services.AddDbContext<DataContext>(options =>
                options.UseSqlServer("Data Source=GAME-PC\\SQLEXPRESS;Initial Catalog=ContractsManager_API;Integrated Security=True;Trust Server Certificate=True")
                .LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information));

            services.AddScoped<JwtTokenService>();
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();


            services.AddMediatR(cfg =>
            {
                cfg.RegisterServicesFromAssembly(typeof(CriarContratoHandler).Assembly);
                cfg.RegisterServicesFromAssembly(typeof(UsuarioHandler).Assembly);
                cfg.RegisterServicesFromAssembly(typeof(BuscarContratoHandler).Assembly);
                cfg.RegisterServicesFromAssembly(typeof(LoginHandler).Assembly);
            });


            return services;
        }
    }
}
