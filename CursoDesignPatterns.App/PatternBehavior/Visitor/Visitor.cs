using DesignPatterns.App.PatternBehavior.Visitor;

namespace CursoDesignPatterns.App.PatternBehavior.Visitor;

public class Visitor
{
    public static void Executar()
    {
        new Fiscal().CalcularImposto();
    }
}
