using DesignPatterns.App.PatternBehavior.Visitor.Interfaces;
using DesignPatterns.App.PatternBehavior.Visitor.Produtos;

namespace DesignPatterns.App.PatternBehavior.Visitor.Visitors;

internal class SaoPauloVisitor : IVisitor
{
    public double CalcularImpostoProdutoNaoPerecivel(ProdutoNaoPerecivel produtoNaoPerecivel)
    {
        var imposto = (produtoNaoPerecivel.Peso / 100) + 5;
        Console.WriteLine($"Imposto de Sao Paulo: {imposto}");
        return imposto;
    }

    public double CalcularImpostoProdutoPerecivel(ProdutoPerecivel produtoPerecivel)
    {
        var imposto = (produtoPerecivel.Peso / 100) + 10;
        Console.WriteLine($"Imposto de Sao Paulo: {imposto}");
        return imposto;
    }
}
