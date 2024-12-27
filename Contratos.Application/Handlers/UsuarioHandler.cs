using Contratos.Application.Commands.CriarUsuario;
using Contratos.Domain.Entities;
using Contratos.Infraestucture.Context;
using MediatR;

namespace Contratos.Application.Handlers
{
    public class UsuarioHandler : IRequestHandler<UsuarioCommand, Guid>
    {
        private readonly DataContext _dbContext;

        public UsuarioHandler(DataContext dataContext)
        {
            _dbContext = dataContext;
        }

        public async Task<Guid> Handle(UsuarioCommand request, CancellationToken cancellationToken)
        {
            var usuario = new UsuarioModel(
                request.Nome,
                request.Email,
                request.Senha,
                request.Role,
                request.Ativo
            );

            await _dbContext.Usuarios.AddAsync(usuario);
            await _dbContext.SaveChangesAsync();

            return usuario.Id;
        }
    }
}
