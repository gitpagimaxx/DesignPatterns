using DesignPatterns.App.PatternBehavior.Iterator.Interfaces;

namespace DesignPatterns.App.PatternBehavior.Iterator;

public class Iterators : IIterator
{
    private IAggregate _aggregate;
    private int _position;

    public Iterators(IAggregate agregate, int position = 0)
    {
        _aggregate = agregate;
        _position = position;
    }

    public string Next => _aggregate[_position++];

    public bool HasNext => _position <= _aggregate.Limit;
}
