using ControleCaixaDomain.Domain;
using ControleCaixaWeb.Controllers;
using Interface;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace ControleCaixaTestes.Controller
{
    public class PedidoControllerTestes
    {
        [Fact(DisplayName = "VisualizarPedidos - retorna pedidos com sucesso")]
        public void VisualizarPedidos()
        {
            var pedidoService = new Mock<IPedidoService>();
            var controller = new PedidoController(pedidoService.Object);

            var result = controller.VisualizarPedidos();

            Task<IEnumerable<Pedido>> ok = Assert.IsAssignableFrom<Task<IEnumerable<Pedido>>>(result);
            Assert.NotNull(result);
            Assert.Equal(result, ok);
        }

        [Fact(DisplayName = "  GravarPedido - Grava pedidos com sucesso")]
        public void GravarPedido()
        {
            var pedidoService = new Mock<IPedidoService>();
            var controller = new PedidoController(pedidoService.Object);
            Pedido p = new Pedido();

            var result = controller.GravarPedido(p);

            Task<string> ok = Assert.IsAssignableFrom<Task<string>>(result);
            Assert.NotNull(result);
            Assert.Equal(result, ok);
        }

        [Fact(DisplayName = "AtualizarPedido - Atualiza pedidos com sucesso")]
        public void AtualizarPedido()
        {
            var pedidoService = new Mock<IPedidoService>();
            var controller = new PedidoController(pedidoService.Object);
            Pedido p = new Pedido();

            var result = controller.AtualizarPedido(p);

            Task<string> ok = Assert.IsAssignableFrom<Task<string>>(result);
            Assert.NotNull(result);
            Assert.Equal(result, ok);
        }

        [Fact(DisplayName = "ApagarPedido - apaga pedidos com sucesso")]
        public void ApagarPedido()
        {
            var pedidoService = new Mock<IPedidoService>();
            var controller = new PedidoController(pedidoService.Object);

            var result = controller.ApagarPedido(1);

            Task<string> ok = Assert.IsAssignableFrom<Task<string>>(result);
            Assert.NotNull(result);
            Assert.Equal(result, ok);
        }
    }
}