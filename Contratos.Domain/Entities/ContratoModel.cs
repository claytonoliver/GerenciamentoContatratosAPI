using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contratos.Domain.Enum;

namespace Contratos.Domain.Entities
{
    public class ContratoModel  
    {
        [Key]
        public Guid Id { get; private set; }
        public string NomeCliente { get; private set; }
        public Decimal MontanteTotal { get; private set; }
        public DateTime DataInicio { get; private set; }
        public DateTime DataFim { get; private set; }
        public ContratoStatusEnum Status { get; private set; }

        public ContratoModel(string nomeCliente,
            decimal montanteTotal, 
            DateTime dataInicio,
            DateTime dataFim,
            ContratoStatusEnum status)
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
            Status = ContratoStatusEnum.concluido;
        }


    }
}
