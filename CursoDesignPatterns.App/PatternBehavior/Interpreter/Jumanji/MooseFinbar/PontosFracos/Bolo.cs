namespace DesignPatterns.App.PatternBehavior.Interpreter.Jumanji.MooseFinbar.PontosFracos;

public class Bolo : IPontoFraco
{
    public void Interpretar(Contexto contexto)
    {
        contexto.Conteudo += "[-] Alergia mortal a Bolo\n";
    }
}
