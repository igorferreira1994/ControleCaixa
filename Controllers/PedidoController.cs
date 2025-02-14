using ControleCaixaDomain.Domain;
using Interface;
using Microsoft.AspNetCore.Mvc;

namespace ControleCaixaWeb.Controllers
{
    [ApiController]
    [Route("controller")]
    public class PedidoController : Controller
    {
        private readonly IPedidoService _pedidoService;      

        public PedidoController(IPedidoService pedidoService)
        {
            _pedidoService = pedidoService;
        }

        [HttpGet()]
        public async Task<IEnumerable<Pedido>> VisualizarPedidos() 
        {
            return await _pedidoService.LerPedidos();
        }

        [HttpPost()]
        public async Task<string> GravarPedido(Pedido pedido)
        {                   
            return await _pedidoService.GravarPedido(pedido);
        }

        [HttpPatch()]
        public async Task<string> AtualizarPedido(Pedido pedido)
        {
            return await _pedidoService.AtualizarPedido(pedido);
        }

        [HttpDelete()]
        public async Task<string> ApagarPedido(int idPedido)
        {
            return await _pedidoService.ApagarPedido(idPedido);
        }

    }
}
