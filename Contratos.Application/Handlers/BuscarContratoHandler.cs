using Contratos.Application.Queries;
using Contratos.Domain.Entities;
using Contratos.Infraestucture.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Contratos.Application.Handlers
{
    public class BuscarContratoHandler : IRequestHandler<BuscarContratoQueries, ContratoModel>
    {
        private readonly DataContext _dbContext;

        public BuscarContratoHandler(DataContext dataContext)
        {
            _dbContext = dataContext;
        }

        public async Task<ContratoModel> Handle(BuscarContratoQueries request, CancellationToken cancellationToken)
        {
            return await _dbContext.Contratos.FirstOrDefaultAsync(c => c.Id == request.Id);
        }
    }
}
