using ControleCaixaDomain.Domain;
using Microsoft.EntityFrameworkCore;
using Interface;

namespace Repository
{
    public class PedidoRepository : IPedidoRepository
    {
        public readonly Context _context;
        public PedidoRepository(Context context)
        {
            _context = context;
        }

        public async Task<string> ApagarPedido(int idPedido)
        {
            var pd = _context.Pedido.FirstOrDefault(x => x.Id == idPedido);
            if (pd != null)
            {
                _context.Pedido.Remove(pd);
                _context.SaveChanges();
                return "Pedido removido com sucesso";
            }
            return "Pedido não encontrado";
        }

        public async Task<string> AtualizarPedido(Pedido pedido)
        {
            var pd = _context.Pedido.FirstOrDefault(x => x.Id == pedido.Id);
            if (pd != null)
            {
                pd.Valor = pedido.Valor;
                pd.Descricao = pedido.Descricao;
                pd.DataPedido = pedido.DataPedido;
                pd.Lancamento = pedido.Lancamento; 
                _context.SaveChanges();
                return "Pedido atualizado com sucesso";
            }
            return "Pedido não encontrado";
        }

        public async Task<string> GravarPedido(Pedido pedido)
        {
            try
            {
                _context.Pedido.Add(pedido);
                _context.SaveChanges();
                return "Pedido gravado com sucesso";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public async Task<IEnumerable<Pedido>> LerPedidos()
        {
            return await _context.Pedido.ToListAsync();
        }
    }
}
