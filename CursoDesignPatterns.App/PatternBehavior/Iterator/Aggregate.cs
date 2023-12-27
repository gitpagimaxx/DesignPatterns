using DesignPatterns.App.PatternBehavior.Iterator.Interfaces;

namespace DesignPatterns.App.PatternBehavior.Iterator;

public class Aggregate : IAggregate
{
    private List<string> Collection = null;
    private int count = 0;

    public Aggregate()
    {
        Collection = new List<string>();
    }

    public IIterator GetIterator()
    {
        return new Iterators(this);
    }

    public string this[int index]
    {
        get
        {
            if (index < Collection.Count)
                return Collection[index];
            else
                return String.Empty;
        }
        set
        {
            Collection.Add(value);
        }
    }

    public int Limit => Collection.Count;

}
