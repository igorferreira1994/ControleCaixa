using ControleCaixaDomain.Domain;

namespace Interface
{
    public interface IPedidoRepository
    {
        public Task<string> ApagarPedido(int idPedido);
        public Task<string> AtualizarPedido(Pedido pedido);
        public Task<string> GravarPedido(Pedido pedido);
        public Task<IEnumerable<Pedido>> LerPedidos();
    }
}
