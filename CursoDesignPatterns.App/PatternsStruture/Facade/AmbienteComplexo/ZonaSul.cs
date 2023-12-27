namespace CursoDesignPatterns.App.PatternsStruture.Facade.AmbienteComplexo;

internal class ZonaSul
{
    public List<object> ExecutaRotinaVendasPerdidas(DateTime periodo)
    {
        Console.WriteLine("[!] Executando complexidade rotina de vendas perdidas região Sul. Periodo: " + periodo);

        return new List<object>();
    }
}
