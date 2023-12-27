using DesignPatterns.App.PatternBehavior.State.Interfaces;

namespace DesignPatterns.App.PatternBehavior.State.Estados;

public class EstadoA : IEstado
{
    public void Acao(Context context)
    {
        Console.WriteLine("Executando ações do Estado A");
        context.Estado = new EstadoB();
    }
}