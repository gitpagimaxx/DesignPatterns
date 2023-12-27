using CursoDesignPatterns.App.PatternsStruture.Flyweight.Model;

namespace CursoDesignPatterns.App.PatternsStruture.Flyweight.Flyweights;

internal class Azul : EspacoNave
{
    public Azul()
    {
        condicao = "voando em linha reta - ";
        acao = "disparando lasers ";
    }

    public override void Exibir(string cor, string tamanho)
    {
        this.cor = cor;
        this.tamanho = tamanho;
        Console.WriteLine($"Nave {this.tamanho} e {this.cor} {this.condicao} {this.acao}");
    }
}
