using DesignPatterns.App.PatternBehavior.Visitor.Interfaces;

namespace DesignPatterns.App.PatternBehavior.Visitor.Produtos;

public class ProdutoPerecivel : IProduto
{
    public ProdutoPerecivel(string nome, double peso)
    {
        Nome = nome;
        Peso = peso;
    }

    public string Nome { get; set; }
    public double Peso { get; set; }

    public double GetImposto(IVisitor visitor)
    {
        return visitor.CalcularImpostoProdutoPerecivel(this);
    }
}
