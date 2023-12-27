using DesignPatterns.App.PatternBehavior.Observer.Interfaces;

namespace DesignPatterns.App.PatternBehavior.Observer.Subjects;

public class PrimeVideos : ISujeito
{
    public List<IObservavel> Observaveis { get; set; }

    public PrimeVideos() 
    {
        Observaveis = new List<IObservavel>();
    }

    public void AddObservavel(IObservavel observavel)
    {
        Observaveis.Add(observavel);
    }

    public void NotificarObservavel()
    {
        foreach (var item in Observaveis)
        {
            item.Update();
            Console.WriteLine(new String('-', 50));
        }
    }

    public void RemoveObservavel(IObservavel observavel)
    {
        Observaveis.Remove(observavel);
    }
}
