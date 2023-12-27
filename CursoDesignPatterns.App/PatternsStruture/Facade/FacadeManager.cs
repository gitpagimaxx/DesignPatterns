using CursoDesignPatterns.App.PatternsStruture.Facade.AmbienteComplexo;

namespace CursoDesignPatterns.App.PatternsStruture.Facade;

internal class FacadeManager
{
    public void ExecutarComplexidade()
    {
        var norte = new ZonaNorte().ExecutaRotinaVendasPerdidas(DateTime.Now);
        var sul = new ZonaSul().ExecutaRotinaVendasPerdidas(DateTime.Now);
        var leste = new ZonaLeste().ExecutaRotinaVendasPerdidas(DateTime.Now);
        var oeste = new ZonaOeste().ExecutaRotinaVendasPerdidas(DateTime.Now);

        new CloudComputing().GerarRelatorioPerdasGanhos(norte, sul, leste, oeste);
    }
}
