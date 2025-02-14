using ControleCaixaDomain.Domain;
using Interface;
using Repository;


namespace Service
{
    public class PedidoService : IPedidoService
    {   
        private readonly IPedidoRepository _pedidoRepository;

        public PedidoService(IPedidoRepository pedidoRepository)
        {
            _pedidoRepository = pedidoRepository;
        }

        public async Task<string> ApagarPedido(int idPedido)
        {
            return await _pedidoRepository.ApagarPedido(idPedido);
        }

        public async Task<string> AtualizarPedido(Pedido pedido)
        {
            return await _pedidoRepository.AtualizarPedido(pedido);
        }

        public async Task<string> GravarPedido(Pedido Pedido)
        {          
            return await _pedidoRepository.GravarPedido(Pedido);
        }

        public async Task<IEnumerable<Pedido>> LerPedidos()
        {
            return await _pedidoRepository.LerPedidos();
        }
    }
}
