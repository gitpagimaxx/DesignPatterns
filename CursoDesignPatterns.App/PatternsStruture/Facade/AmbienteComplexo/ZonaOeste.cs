namespace CursoDesignPatterns.App.PatternsStruture.Facade.AmbienteComplexo;

internal class ZonaOeste
{
    public List<object> ExecutaRotinaVendasPerdidas(DateTime periodo)
    {
        Console.WriteLine("[!] Executando complexidade rotina de vendas perdidas região Oeste. Periodo: " + periodo);

        return new List<object>();
    }
}
