namespace CursoDesignPatterns.App.PatternsStruture.Facade.AmbienteComplexo;

internal class ZonaLeste
{
    public List<object> ExecutaRotinaVendasPerdidas(DateTime periodo)
    {
        Console.WriteLine("[!] Executando complexidade rotina de vendas perdidas região Leste. Periodo: " + periodo);

        return new List<object>();
    }
}
