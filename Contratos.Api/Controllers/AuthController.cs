using Contratos.Application.Commands.CriarUsuario;
using Contratos.Application.Commands.Usuario;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Contratos.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AuthController(IMediator mediator)
        {
            _mediator = mediator;
        }

        //[HttpPost]
        //public async Task<IActionResult> Register([FromBody] UsuarioCommand command)
        //{
        //    var id = await _mediator.Send(command);

        //    return CreatedAtAction(nameof(Login), new { id });
        //}

        [HttpPost]
        public async Task<IActionResult> Login([FromBody] LoginCommand command)
        {
            var token = await _mediator.Send(command);

            if (token == null)
                return Unauthorized();

            return Ok(new { token });
        }
    }
}
