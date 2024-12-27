using Contratos.Domain.Enum;
using MediatR;

namespace Contratos.Application.Commands.CriarUsuario
{
    public class UsuarioCommand : IRequest<Guid>
    {
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }
        public RoleEnum Role { get; private set; }
        public SByte Ativo { get; private set; }

        public UsuarioCommand(string nome, string email, string senha, RoleEnum role, sbyte ativo)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            Role = role;
            Ativo = ativo;
        }
    }
}
