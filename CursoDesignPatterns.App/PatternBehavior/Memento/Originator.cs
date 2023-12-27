namespace DesignPatterns.App.PatternBehavior.Memento;

public class Originator
{
    private string _estado;

    public string Estado
    {
        get { return _estado; }
        set
        {
            _estado = value;
            Console.WriteLine($"O estado atual é {_estado}");
        }
    }

    public Snapshot CriarSnapshot()
    {
        return (new Snapshot(_estado));
    }

    public void Restore(Snapshot snapshot)
    {
        Console.WriteLine("Restaurando estado...");
        Thread.Sleep(2000);
        Estado = snapshot.ObterEstado();
    }
}