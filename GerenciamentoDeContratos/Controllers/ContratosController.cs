using Contratos.Application.Commands;
using Contratos.Shared.Common.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GerenciamentoDeContratos.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContratosController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IContratoRepository _contratoRepository;

        public ContratosController(IMediator mediator, IContratoRepository contratoRepository)
        {
            _mediator = mediator;
            _contratoRepository = contratoRepository;
        }

        [HttpPost]
        public async Task<IActionResult> CriarContrato([FromBody] CriarContratoCommand command)
        {
            var contratoId = await _mediator.Send(command);
            return CreatedAtAction(nameof(ObterContrato), new { id = contratoId }, contratoId);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> ObterContrato(Guid id)
        {
            var contrato = await _contratoRepository.GetByIdAsync(id);

            if (contrato == null)
                return NotFound();

            return Ok(contrato);
        }

        //[HttpGet]
        //public async Task<IActionResult> ObterContratos()
        //{
        //    var contratos = await _mediator.Send(new ObterContratosQuery());
        //    return contratos == null ? NotFound() : Ok(contratos);
        //}
    }
}
