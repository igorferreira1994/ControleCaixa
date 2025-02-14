using ControleCaixaDomain.Domain;
using ControleCaixaWeb.Controllers;
using Interface;
using Moq;
using Service;

namespace ControleCaixaTestes.Controller
{
    public class PedidoServiceTestes
    {
        [Fact(DisplayName = "VisualizarPedidosService - retorna pedidos com sucesso")]
        public void VisualizarPedidosService()
        {
            var pedidoRepository= new Mock<IPedidoRepository>();
            var service = new PedidoService(pedidoRepository.Object);
            List<Pedido> pedidos = new List<Pedido>();
            pedidoRepository.Setup(data => data.LerPedidos()).ReturnsAsync(pedidos);

            var result = service.LerPedidos();

            Task<IEnumerable<Pedido>> ok = Assert.IsAssignableFrom<Task<IEnumerable<Pedido>>>(result);
            Assert.NotNull(result);
            Assert.Equal(result, ok);
        }

        [Fact(DisplayName = "GravarPedidoService - Grava pedidos com sucesso")]
        public void GravarPedidoService()
        {
            var pedidoRepository = new Mock<IPedidoRepository>();
            var service = new PedidoService(pedidoRepository.Object);           
            Pedido p = new Pedido();
            string test = "sucesso";
            pedidoRepository.Setup(data => data.GravarPedido(It.IsAny<Pedido>())).ReturnsAsync(test);

            var result = service.GravarPedido(p);

            Task<string> ok = Assert.IsAssignableFrom<Task<string>>(result);
            Assert.NotNull(result);
            Assert.Equal(result, ok);
        }

        [Fact(DisplayName = "AtualizarPedidoService - Atualiza pedidos com sucesso")]
        public void AtualizarPedidoService()
        {
            var pedidoRepository = new Mock<IPedidoRepository>();
            var service = new PedidoService(pedidoRepository.Object);
            Pedido p = new Pedido();
            string test = "sucesso";
            pedidoRepository.Setup(data => data.AtualizarPedido(It.IsAny<Pedido>())).ReturnsAsync(test);

            var result = service.AtualizarPedido(p);

            Task<string> ok = Assert.IsAssignableFrom<Task<string>>(result);
            Assert.NotNull(result);
            Assert.Equal(result, ok);
        }

        [Fact(DisplayName = "ApagarPedidoService - apaga pedidos com sucesso")]
        public void ApagarPedidoService()
        {
            var pedidoRepository = new Mock<IPedidoRepository>();
            var service = new PedidoService(pedidoRepository.Object);
            string test = "sucesso";
            pedidoRepository.Setup(data => data.ApagarPedido(It.IsAny<int>())).ReturnsAsync(test);

            var result = service.ApagarPedido(1);

            Task<string> ok = Assert.IsAssignableFrom<Task<string>>(result);
            Assert.NotNull(result);
            Assert.Equal(result, ok);
        }
    }
}