using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleCaixaDomain.Domain
{
    public class Relatorio
    {        
        public int QuantidadeCredito { get; set; }
        public int QuantidadeDebito { get; set; }
        public decimal ValorCredito { get; set; }
        public decimal ValorDebito { get; set; }
        public decimal SaldoFinal { get; set; }
    }   
}
