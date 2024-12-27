﻿using Contratos.Application.Commands.CriarContrato.Response;
using Contratos.Application.Queries;
using Contratos.Shared.Common.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace GerenciamentoDeContratos.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContratosController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ContratosController(IMediator mediator, IContratoRepository contratoRepository)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CriarContrato([FromBody] CriarContratoResponse command)
        {
            var contratoId = await _mediator.Send(command);
            return CreatedAtAction(nameof(ObterContrato), new { id = contratoId }, contratoId);
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
