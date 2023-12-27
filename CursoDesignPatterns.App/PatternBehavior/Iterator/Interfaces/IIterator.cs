namespace DesignPatterns.App.PatternBehavior.Iterator.Interfaces;

public interface IIterator
{
    string Next { get; }  
    bool HasNext { get; }
}
