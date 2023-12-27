namespace DesignPatterns.App.PatternBehavior.Interpreter.Jumanji.MooseFinbar.PontosFracos;

public class Velocidade : IPontoFraco
{
    public void Interpretar(Contexto contexto)
    {
        contexto.Conteudo += "[-] Velocidade\n";
    }
}
