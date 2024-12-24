using MediatR;

namespace Contratos.Application.Commands
{
    public record CriarContratoCommand(string NomeCliente, decimal MontanteTotal, DateTime DataInicio, DateTime DataFim, string Status) : IRequest<Guid>;
}
