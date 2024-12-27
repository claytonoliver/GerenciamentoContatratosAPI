using Contratos.Application.Commands.CriarContrato;
using Contratos.Application.Commands.CriarContrato.Request;
using Contratos.Application.Commands.CriarContrato.Response;
using Contratos.Application.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace GerenciamentoDeContratos.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContratosController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ContratosController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CriarContrato([FromBody] CriarContratoCommand command)
        {
            var contratoId = await _mediator.Send(command);

            var response = new CriarContratoResponse(
                contratoId,
                command.NomeCliente,
                command.MontanteTotal,
                command.DataInicio,
                command.DataFim,
                command.Status.ToString()
            );

            return CreatedAtAction(nameof(ObterContrato), new { id = contratoId }, response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> ObterContrato(Guid id)
        {
            var contrato = await _mediator.Send(new BuscarContratoQueries(id));

            if (contrato == null)
                return NotFound();

            return Ok(contrato);
        }
    }
}
