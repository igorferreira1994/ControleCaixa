using ControleCaixaDomain.Domain;
using Interface;
using Microsoft.AspNetCore.Mvc;

namespace ControleCaixaWeb.Controllers
{
    [ApiController]
    [Route("controller")]
    public class RelatoriosController : Controller
    {
        private readonly IRelatoriosService _relatoriosService;      

        public RelatoriosController(IRelatoriosService relatoriosService)
        {
            _relatoriosService = relatoriosService;
        }

        [HttpGet("RelatorioTodosLancamentos")]
        public async Task<Relatorio> RelatorioTodosLancamentos() 
        {
            return await _relatoriosService.RelatorioTodosLancamentos();
        }

        [HttpGet("RelatorioDiarioConsolidado")]
        public async Task<Relatorio> RelatorioDiarioConsolidado()
        {
            return await _relatoriosService.RelatorioDiarioConsolidado();
        }

        [HttpGet("RelatorioDiaEspecifico")]
        public async Task<Relatorio> RelatorioDiaEspecifico(DateTime dia)
        {
            return await _relatoriosService.RelatorioDiaEspecifico(dia);
        }

    }
}
