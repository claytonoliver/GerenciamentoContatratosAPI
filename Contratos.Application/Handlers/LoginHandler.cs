using Contratos.Application.Commands.Usuario;
using Contratos.Application.Services;
using Contratos.Shared.Common.Interfaces;
using MediatR;

namespace Contratos.Application.Handlers
{
    public class LoginHandler : IRequestHandler<LoginCommand, string>
    {
        private readonly JwtTokenService _jwtTokenService;
        private readonly IUsuarioRepository _usuarioRepository;

        public LoginHandler(JwtTokenService jwt, IUsuarioRepository usuarioRepository)
        {
            _jwtTokenService = jwt;
            _usuarioRepository = usuarioRepository;
        }
        public async Task<string> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            var usuario = await _usuarioRepository.GetUsuarioByEmail(request.Email);

            if (usuario == null || !usuario.VerificarSenha(request.Senha))
            {
                throw new UnauthorizedAccessException("Credenciais inválidas");
            }
            return _jwtTokenService.GenerateToken(usuario);

        }
    }
}
