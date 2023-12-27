using CursoDesignPatterns.App.PatternsStruture.Flyweight.Flyweights;
using CursoDesignPatterns.App.PatternsStruture.Flyweight.Model;

namespace CursoDesignPatterns.App.PatternsStruture.Flyweight;

internal class FlyweightFactory
{
    public readonly Dictionary<string, EspacoNave> nave_lista = new();

    public EspacoNave GetEspacoNave(string cor)
    {
        EspacoNave nave;
        if (nave_lista.ContainsKey(cor))
        {
            nave = nave_lista[cor];
        }
        else
        {
            nave = cor switch
            {
                "azul" => new Azul(),
                "cinza" => new Cinza(),
                "vermelha" => new Vermelha(),
                _ => throw new NotImplementedException(),
            };

            nave_lista.Add(cor, nave);
        }

        return nave;
    }
}
