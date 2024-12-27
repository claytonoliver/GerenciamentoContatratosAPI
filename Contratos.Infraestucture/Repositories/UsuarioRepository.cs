using Contratos.Domain.Entities;
using Contratos.Infraestucture.Context;
using Contratos.Shared.Common.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Contratos.Infraestucture.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly DataContext _dbContext;
        public UsuarioRepository(DataContext dataContext)
        {
            _dbContext = dataContext;
        }

        public Task<UsuarioModel> CreateUsuario(UsuarioModel usuario)
        {
            throw new NotImplementedException();
        }

        public Task<UsuarioModel> DeleteUsuario(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<UsuarioModel>> GetAllUsuarios()
        {
            throw new NotImplementedException();
        }

        public async Task<UsuarioModel> GetUsuarioByEmail(string email)
        {
            return await _dbContext.Usuarios.FirstOrDefaultAsync(x => x.Email == email);

        }

        public Task<UsuarioModel> GetUsuarioById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<UsuarioModel> UpdateUsuario(UsuarioModel usuario)
        {
            throw new NotImplementedException();
        }
    }
}
