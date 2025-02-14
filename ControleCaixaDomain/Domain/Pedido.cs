using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleCaixaDomain.Domain
{
    public class Pedido
    {
        [Key]
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public string? Descricao { get; set; }
        public decimal Valor { get; set; }
        public string? Lancamento { get; set; }
    }   
}
