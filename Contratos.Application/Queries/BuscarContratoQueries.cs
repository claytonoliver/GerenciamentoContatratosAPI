using Contratos.Domain.Entities;
using MediatR;

namespace Contratos.Application.Queries
{
    public record BuscarContratoQueries(Guid Id) : IRequest<ContratoModel>;
}
