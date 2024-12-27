using Contratos.Application.Commands.CriarContrato;
using Contratos.Domain.Entities;
using Contratos.Infraestucture.Context;
using MediatR;

namespace Contratos.Application.Handlers
{
    public class CriarContratoHandler : IRequestHandler<CriarContratoCommand, Guid>
    {
        private readonly DataContext _dbContext;

        public CriarContratoHandler(DataContext dbcontext)
        {
            _dbContext = dbcontext;
        }

        public async Task<Guid> Handle(CriarContratoCommand request, CancellationToken cancellationToken)
        {
            var contrato = new ContratoModel(
                request.NomeCliente,
                request.MontanteTotal, 
                request.DataInicio,
                request.DataFim, 
                request.Status
                );
            await _dbContext.Contratos.AddAsync(contrato);
            await _dbContext.SaveChangesAsync();

            return contrato.Id;
        }
    }
}
