using DesignPatterns.App.PatternBehavior.Strategy.Interfaces;

namespace DesignPatterns.App.PatternBehavior.Strategy;

public static class CalculaTaxaServico
{
    public static void Calcular(List<IServico> servicos)
    {
        foreach (var item in servicos)
        {
            item.CalcularServico();
            Console.WriteLine(new string('-', 40));
        }
    }
}
