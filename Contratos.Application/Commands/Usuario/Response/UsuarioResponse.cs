using Contratos.Domain.Entities;
using Contratos.Domain.Enum;

namespace Contratos.Application.Commands.CriarUsuario.Response
{
    public class UsuarioResponse
    {
        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }
        public RoleEnum Role { get; private set; }
        public SByte Ativo { get; private set; }

        public UsuarioResponse(Guid id,
            string nome,
            string email,
            string senha,
            RoleEnum role,
            SByte ativo)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Senha = senha;
            Role = role;
            Ativo = ativo;
        }
    }
}
