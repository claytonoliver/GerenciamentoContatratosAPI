using Contratos.Domain.Entities;

namespace Contratos.Shared.Common.Interfaces
{
    public interface IUsuarioRepository
    {
        Task<UsuarioModel> GetUsuarioByEmail(string email);
        Task<UsuarioModel> GetUsuarioById(Guid id);
        Task<UsuarioModel> CreateUsuario(UsuarioModel usuario);
        Task<UsuarioModel> UpdateUsuario(UsuarioModel usuario);
        Task<UsuarioModel> DeleteUsuario(Guid id);
        Task<IEnumerable<UsuarioModel>> GetAllUsuarios();
    }
}
