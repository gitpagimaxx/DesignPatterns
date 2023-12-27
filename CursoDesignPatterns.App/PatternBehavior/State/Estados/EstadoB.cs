using DesignPatterns.App.PatternBehavior.State.Interfaces;

namespace DesignPatterns.App.PatternBehavior.State.Estados;

public class EstadoB : IEstado
{
    public void Acao(Context context)
    {
        Console.WriteLine("Executando ações do Estado B");
        context.Estado = new EstadoA();
    }
}