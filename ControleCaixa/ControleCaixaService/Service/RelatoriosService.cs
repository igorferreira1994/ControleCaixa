using ControleCaixaDomain.Domain;
using Interface;
using Repository;

namespace Service
{
    public class RelatoriosService : IRelatoriosService
    {   
        private readonly IRelatoriosRepository _relatoriosRepository;

        public RelatoriosService(IRelatoriosRepository relatoriosRepository)
        {
            _relatoriosRepository = relatoriosRepository;
        }

        public async Task<Relatorio> RelatorioDiaEspecifico(DateTime dia)
        {
            return await _relatoriosRepository.RelatorioDiaEspecifico(dia);
        }

        public async Task<Relatorio> RelatorioDiarioConsolidado()
        {
            return await _relatoriosRepository.RelatorioDiarioConsolidado();
        }

        public async Task<Relatorio> RelatorioTodosLancamentos()
        {
            return await _relatoriosRepository.RelatorioTodosLancamentos();
        }
    }
}
