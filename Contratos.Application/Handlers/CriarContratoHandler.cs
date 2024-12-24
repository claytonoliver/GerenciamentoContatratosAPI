using Contratos.Application.Commands;
using Contratos.Domain.Entities;
using Contratos.Shared.Common.Interfaces;
using MediatR;

namespace Contratos.Application.Handlers
{
    public class CriarContratoHandler : IRequestHandler<CriarContratoCommand, Guid>
    {
        private readonly IContratoRepository _contratoRepository;

        public CriarContratoHandler(IContratoRepository contratoRepository)
        {
            _contratoRepository = contratoRepository;
        }

        public async Task<Guid> Handle(CriarContratoCommand request, CancellationToken cancellationToken)
        {
            var contrato = new ContratoModel(request.NomeCliente, request.MontanteTotal, request.DataInicio, request.DataFim, request.Status);
            await _contratoRepository.AddAsync(contrato);
            return contrato.Id;
        }
    }
}
