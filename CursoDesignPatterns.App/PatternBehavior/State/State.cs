using DesignPatterns.App.PatternBehavior.State;
using DesignPatterns.App.PatternBehavior.State.Estados;

namespace CursoDesignPatterns.App.PatternBehavior.State;

public class State
{
    public static void Executar()
    {
        Context context = new(new EstadoA());

        context.Trocar();
        context.Trocar();
    }
}
