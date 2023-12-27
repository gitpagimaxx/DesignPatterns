using DesignPatterns.App.PatternBehavior.Visitor.Interfaces;

namespace DesignPatterns.App.PatternBehavior.Visitor.Produtos;

public class ProdutoNaoPerecivel : IProduto
{
    public ProdutoNaoPerecivel(string nome, double peso)
    {
        Nome = nome;
        Peso = peso;
    }

    public string Nome { get; set; }
    public double Peso { get; set; }

    public double GetImposto(IVisitor visitor)
    {
        return visitor.CalcularImpostoProdutoNaoPerecivel(this);
    }
}
