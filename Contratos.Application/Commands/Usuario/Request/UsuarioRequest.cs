using Contratos.Domain.Enum;

namespace Contratos.Application.Commands.CriarUsuario.Request
{
    public class UsuarioRequest
    {
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }
        public RoleEnum Role { get; private set; }
        public SByte Ativo { get; private set; }
    }
}
