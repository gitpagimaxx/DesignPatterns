namespace DesignPatterns.App.PatternBehavior.Memento;

public class Videocassete
{
    public static void ExecutarAcaoVideo()
    {
        Originator originator = new();
        originator.Estado = "play";

        Caretaker caretaker = new();
        caretaker.AddSnapshot(originator.CriarSnapshot());

        originator.Estado = "pause";

        originator.Restore(caretaker.ObterSnapshot());
    }
}