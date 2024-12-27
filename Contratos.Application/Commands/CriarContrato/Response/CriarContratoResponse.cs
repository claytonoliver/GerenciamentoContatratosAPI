namespace Contratos.Application.Commands.CriarContrato.Response
{
    public class CriarContratoResponse
    {
        public Guid Id { get; private set; }
        public string NomeCliente { get; private set; }
        public Decimal MontanteTotal { get; private set; }
        public DateTime DataInicio { get; private set; }
        public DateTime DataFim { get; private set; }
        public string Status { get; private set; }

        public CriarContratoResponse(Guid id,
            string nomeCliente,
            Decimal montanteTotal,
            DateTime dataInicio,
            DateTime dataFim,
            string Status)
        {
            Id = id;
            NomeCliente = nomeCliente;
            MontanteTotal = montanteTotal;
            DataInicio = dataInicio;
            DataFim = dataFim;
            Status = Status;
        }
    }
}
