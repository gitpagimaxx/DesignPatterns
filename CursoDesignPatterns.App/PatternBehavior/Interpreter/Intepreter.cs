using DesignPatterns.App.PatternBehavior.Interpreter.Jumanji.MooseFinbar.PontosFortes;
using DesignPatterns.App.PatternBehavior.Interpreter.Jumanji.MooseFinbar.PontosFracos;
using DesignPatterns.App.PatternBehavior.Interpreter.Jumanji;

namespace CursoDesignPatterns.App.PatternBehavior.Interpreter;

public class Intepreter
{
    public static void Executar()
    {
        List<IPontoForte> pontoFortes = new()
        {
            new Armeiro(), new Zoologia()
        };

        List<IPontoFraco> pontoFracos = new()
        {
            new Bolo(), new Forca(), new Velocidade()
        };

        Contexto mossoFinbar = new("Mosse Finbar");

        Habilidades habilidades = new(pontoFortes, pontoFracos);
        habilidades.Interpretar(mossoFinbar);
    }
}
