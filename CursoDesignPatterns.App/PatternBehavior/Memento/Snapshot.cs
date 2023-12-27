namespace DesignPatterns.App.PatternBehavior.Memento;

public class Snapshot
{
    private string _estado;

    public Snapshot(string estado)
    {
        _estado = estado;
    }

    public string ObterEstado()
    {
        return _estado;
    }
}