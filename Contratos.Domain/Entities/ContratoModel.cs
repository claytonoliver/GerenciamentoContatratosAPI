using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contratos.Domain.Entities
{
    public class ContratoModel  
    {
        public Guid Id { get; private set; }
        public string NomeCliente { get; private set; }
        public Decimal MontanteTotal { get; private set; }
        public DateTime DataInicio { get; private set; }
        public DateTime DataFim { get; private set; }
        public string Status { get; private set; }

        public ContratoModel(string nomeCliente,
            decimal montanteTotal, 
            DateTime dataInicio,
            DateTime dataFim,
            string status)
        {
            Id = Guid.NewGuid();
            NomeCliente = nomeCliente;
            MontanteTotal = montanteTotal;
            DataInicio = dataInicio;
            DataFim = dataFim;
            Status = status;
        }

        public void AlterarNomeCliente(string nomeCliente)
        {
            NomeCliente = nomeCliente;
        }

        public void AlterarMontanteTotal(decimal montanteTotal)
        {
            MontanteTotal = montanteTotal;
        }

        public void MarcarComoConcluido()
        {
            Status = "Concluido";
        }


    }
}
