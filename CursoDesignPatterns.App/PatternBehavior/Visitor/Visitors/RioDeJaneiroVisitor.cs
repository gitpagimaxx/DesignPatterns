using DesignPatterns.App.PatternBehavior.Visitor.Interfaces;
using DesignPatterns.App.PatternBehavior.Visitor.Produtos;

namespace DesignPatterns.App.PatternBehavior.Visitor.Visitors;

internal class RioDeJaneiroVisitor : IVisitor
{
    public double CalcularImpostoProdutoNaoPerecivel(ProdutoNaoPerecivel produtoNaoPerecivel)
    {
        var imposto = (produtoNaoPerecivel.Peso / 100) + 7;
        Console.WriteLine($"Imposto Rio de Janeiro: {imposto}");
        return imposto;
    }

    public double CalcularImpostoProdutoPerecivel(ProdutoPerecivel produtoPerecivel)
    {
        var imposto = (produtoPerecivel.Peso / 100) + 12;
        Console.WriteLine($"Imposto de Rio de Janeiro: {imposto}");
        return imposto;
    }
}
