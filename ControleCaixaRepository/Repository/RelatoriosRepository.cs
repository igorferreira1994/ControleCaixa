using ControleCaixaDomain.Domain;
using Microsoft.EntityFrameworkCore;
using Interface;

namespace Repository
{
    public class RelatoriosRepository : IRelatoriosRepository
    {
        public readonly Context _context;
        public RelatoriosRepository(Context context)
        {
            _context = context;
        }

        public async Task<Relatorio> RelatorioDiaEspecifico(DateTime dia)
        {
            DateTime diaInicio = new DateTime(dia.Year, dia.Month, dia.Day, 0, 0, 0);
            DateTime diaFim = new DateTime(dia.Year, dia.Month, dia.Day, 23, 59, 59);
            return await MontarRelatorio(_context.Pedido.ToList().Where(x => x.DataPedido <= diaFim & x.DataPedido >= diaInicio).ToList());
        }

        public async Task<Relatorio> RelatorioDiarioConsolidado()
        {
            DateTime dia = DateTime.Now;
            DateTime diaInicio = new DateTime(dia.Year, dia.Month, dia.Day, 0, 0, 0);
            DateTime diaFim = new DateTime(dia.Year, dia.Month, dia.Day, 23, 59, 59);
            return await MontarRelatorio(_context.Pedido.ToList().Where(x => x.DataPedido <= diaFim & x.DataPedido >= diaInicio).ToList());
        }

        public async Task<Relatorio> RelatorioTodosLancamentos()
        {
            return await MontarRelatorio(await _context.Pedido.ToListAsync());
        }

        public async Task<Relatorio> MontarRelatorio(List<Pedido> pedidos)
        {
            Relatorio relatorio = new Relatorio();
            foreach (var item in pedidos)
            {
                if (item.Lancamento.ToLower() == "crédito" || item.Lancamento.ToLower() == "credito")
                {
                    relatorio.ValorCredito += item.Valor;
                    relatorio.QuantidadeCredito++;
                }
                else
                {
                    relatorio.ValorDebito += item.Valor;
                    relatorio.QuantidadeDebito++;
                }
            }
            relatorio.SaldoFinal = relatorio.ValorCredito - relatorio.ValorDebito;
            return relatorio;
        }
    }
}
