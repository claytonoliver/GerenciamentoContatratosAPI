using Contratos.Application.Services;
using MediatR;

namespace Contratos.Application.Commands.Usuario
{
    public record LoginCommand(string Email, string Senha) : IRequest<string>;
    
}
