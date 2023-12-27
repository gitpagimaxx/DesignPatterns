namespace DesignPatterns.App.PatternBehavior.Memento;

public class Caretaker
{
    private Snapshot _snapshot;

    public void AddSnapshot(Snapshot snapshot)
        => _snapshot = snapshot;

    public Snapshot ObterSnapshot() 
        => _snapshot;
}