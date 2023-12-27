using DesignPatterns.App.PatternBehavior.Interpreter.Jumanji.Interfaces;
using DesignPatterns.App.PatternBehavior.Interpreter.Jumanji.MooseFinbar.PontosFortes;
using DesignPatterns.App.PatternBehavior.Interpreter.Jumanji.MooseFinbar.PontosFracos;

namespace DesignPatterns.App.PatternBehavior.Interpreter.Jumanji;

public class Habilidades : IExpression
{
    private readonly List<IPontoForte> _pontoForte;
    private readonly List<IPontoFraco> _pontoFraco;

    public Habilidades(List<IPontoForte> pontoForte, List<IPontoFraco> pontoFraco)
    {
        _pontoForte = pontoForte;
        _pontoFraco = pontoFraco;
    }

    public void Interpretar(Contexto contexto)
    {
        Console.WriteLine($"Personagem: {contexto.Personagem}");

        contexto.Conteudo += "Exibindo Habilidades... \nPontos Fortes:\n--------------\n";
        foreach ( var forte in _pontoForte)
        {
            forte.Interpretar(contexto);
        }

        contexto.Conteudo += "\nPontos Fracos:\n--------------\n";
        foreach (var fraco in _pontoFraco)
        {
            fraco.Interpretar(contexto);
        }

        Console.WriteLine(contexto.Conteudo);
    }
}
