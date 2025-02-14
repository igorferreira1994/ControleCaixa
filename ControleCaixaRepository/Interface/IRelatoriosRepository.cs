using ControleCaixaDomain.Domain;

namespace Interface
{
    public interface IRelatoriosRepository
    {
        public Task<Relatorio> RelatorioDiarioConsolidado();
        public Task<Relatorio> RelatorioTodosLancamentos();
        public Task<Relatorio> RelatorioDiaEspecifico(DateTime dia);
    }
}
