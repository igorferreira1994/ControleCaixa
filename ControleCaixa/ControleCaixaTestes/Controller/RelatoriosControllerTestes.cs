using ControleCaixaDomain.Domain;
using ControleCaixaWeb.Controllers;
using Interface;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace ControleCaixaTestes
{
    public class RelatoriosControllerTestes
    {
        [Fact(DisplayName = "RelatorioTodosLancamentos - Relatorio Todos Lancamentos com sucesso")]
        public void VisualizarPedidos()
        {
            var relatoriosService = new Mock<IRelatoriosService>(); 
            var controller = new RelatoriosController(relatoriosService.Object);

            var result = controller.RelatorioTodosLancamentos();

            Task<Relatorio> ok = Assert.IsAssignableFrom<Task<Relatorio>>(result);
            Assert.NotNull(result);
            Assert.Equal(result,ok);
        }

        [Fact(DisplayName = " RelatorioDiaEspecifico - Relatorio Dia Especifico com sucesso")]
        public void GravarPedido()
        {
            var relatoriosService = new Mock<IRelatoriosService>();
            var controller = new RelatoriosController(relatoriosService.Object);
            

            var result = controller.RelatorioDiaEspecifico(DateTime.Now);

            Task<Relatorio> ok = Assert.IsAssignableFrom<Task<Relatorio>>(result);
            Assert.NotNull(result);
            Assert.Equal(result, ok);
        }

        [Fact(DisplayName = "RelatorioDiarioConsolidado - Relatorio Diario Consolidado com sucesso")]
        public void AtualizarPedido()
        {
            var relatoriosService = new Mock<IRelatoriosService>();
            var controller = new RelatoriosController(relatoriosService.Object);

            var result = controller.RelatorioDiarioConsolidado();

            Task<Relatorio> ok = Assert.IsAssignableFrom<Task<Relatorio>>(result);
            Assert.NotNull(result);
            Assert.Equal(result, ok);
        }
        
    }
}