namespace CursoDesignPatterns.App.PatternsStruture.Flyweight.Model;

internal abstract class EspacoNave
{
    protected string condicao;
    protected string acao;

    public string cor { get; set; }
    public string tamanho { get; set; }

    public abstract void Exibir(string cor, string tamanho);
}
