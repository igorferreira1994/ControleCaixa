using ControleCaixaDomain.Domain;
using ControleCaixaWeb.Controllers;
using Interface;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Repository;
using Service;

namespace ControleCaixaTestes
{
    public class RelatoriosServiceTestes
    {
        [Fact(DisplayName = "RelatorioTodosLancamentosService - Relatorio Todos Lancamentos com sucesso")]
        public void RelatorioTodosLancamentos()
        {
            var relatoriosRepository = new Mock<IRelatoriosRepository>(); 
            var service = new RelatoriosService(relatoriosRepository.Object);
            Relatorio relatorio = new Relatorio();
            relatoriosRepository.Setup(data => data.RelatorioTodosLancamentos()).ReturnsAsync(relatorio);

            var result = service.RelatorioTodosLancamentos();

            Task<Relatorio> ok = Assert.IsAssignableFrom<Task<Relatorio>>(result);
            Assert.NotNull(result);
            Assert.Equal(result,ok);
        }

        [Fact(DisplayName = " RelatorioDiaEspecificoService - Relatorio Dia Especifico com sucesso")]
        public void RelatorioDiaEspecificoService()
        {
            var relatoriosRepository = new Mock<IRelatoriosRepository>();
            var service = new RelatoriosService(relatoriosRepository.Object);
            Relatorio relatorio = new Relatorio();
            relatoriosRepository.Setup(data => data.RelatorioDiaEspecifico(It.IsAny<DateTime>())).ReturnsAsync(relatorio);

            var result = service.RelatorioDiaEspecifico(DateTime.Now);

            Task<Relatorio> ok = Assert.IsAssignableFrom<Task<Relatorio>>(result);
            Assert.NotNull(result);
            Assert.Equal(result, ok);
        }

        [Fact(DisplayName = "RelatorioDiarioConsolidadoService - Relatorio Diario Consolidado com sucesso")]
        public void RelatorioDiarioConsolidadoService()
        {
            var relatoriosRepository = new Mock<IRelatoriosRepository>();
            var service = new RelatoriosService(relatoriosRepository.Object);
            Relatorio relatorio = new Relatorio();
            relatoriosRepository.Setup(data => data.RelatorioDiarioConsolidado()).ReturnsAsync(relatorio);

            var result = service.RelatorioDiarioConsolidado();

            Task<Relatorio> ok = Assert.IsAssignableFrom<Task<Relatorio>>(result);
            Assert.NotNull(result);
            Assert.Equal(result, ok);
        }
        
    }
}