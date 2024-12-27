namespace Contratos.Application.Commands.CriarContrato.Request
{
    public class CriarContratoRequest
    {
        public string NomeCliente { get; private set; }
        public Decimal MontanteTotal { get; private set; }
        public DateTime DataInicio { get; private set; }
        public DateTime DataFim { get; private set; }
        public string Status { get; private set; }
    }
}
