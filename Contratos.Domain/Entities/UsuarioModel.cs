using System.ComponentModel.DataAnnotations;
using Contratos.Domain.Enum;

namespace Contratos.Domain.Entities
{
    public class UsuarioModel
    {
        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }
        public int Role { get; private set; }
        public SByte Ativo { get; private set; }
        public string RoleName => ((RoleEnum)Role).GetRoleName();

        private UsuarioModel() { }

        public UsuarioModel(
            string nome,
            string email,
            string senha,
            RoleEnum role,
            SByte ativo)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Email = email;
            Senha = HashPassword(senha);
            Role = (int)role;
            Ativo = ativo;
        }

        public static string HashPassword(string senha)
        {
            return BCrypt.Net.BCrypt.HashPassword(senha);
        }

        public bool VerificarSenha(string senha)
        {
            return BCrypt.Net.BCrypt.Verify(senha, Senha);
        }
    }
}
