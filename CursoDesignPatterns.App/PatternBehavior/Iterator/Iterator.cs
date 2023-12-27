using DesignPatterns.App.PatternBehavior.Iterator;
using DesignPatterns.App.PatternBehavior.Iterator.Interfaces;

namespace CursoDesignPatterns.App.PatternBehavior.Iterator;

public class Iterator
{
    public static void Executar()
    {
        Aggregate aggregate = new();
        aggregate[0] = "Item 01";
        aggregate[1] = "Item 02";
        aggregate[2] = "Item 03";

        IIterator iterator = aggregate.GetIterator();

        for (string item = iterator.Next; iterator.HasNext; item = iterator.Next)
        {
            Console.WriteLine(item);
        }
    }
}
