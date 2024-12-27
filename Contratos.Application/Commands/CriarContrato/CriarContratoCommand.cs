using Contratos.Application.Commands.CriarContrato.Response;
using Contratos.Domain.Enum;
using MediatR;

namespace Contratos.Application.Commands.CriarContrato
{
    public class CriarContratoCommand : IRequest<Guid>
    {
        public string NomeCliente { get;}
        public Decimal MontanteTotal { get;}
        public DateTime DataInicio { get;}
        public DateTime DataFim { get;}
        public ContratoStatusEnum Status { get;}

        public CriarContratoCommand(string nomeCliente,
            Decimal montanteTotal,
            DateTime dataInicio,
            DateTime dataFim,
            ContratoStatusEnum status)
        {
            NomeCliente = nomeCliente;
            MontanteTotal = montanteTotal;
            DataInicio = dataInicio;
            DataFim = dataFim;
            Status = status;
        }
    }
}
