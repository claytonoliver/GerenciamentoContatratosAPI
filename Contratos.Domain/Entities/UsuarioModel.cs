namespace Contratos.Domain.Entities
{
    public class UsuarioModel
    {
        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }
        public string Role { get; private set; }
    }
}
