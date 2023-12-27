using DesignPatterns.App.PatternBehavior.Visitor.Produtos;

namespace DesignPatterns.App.PatternBehavior.Visitor.Interfaces;

public interface IVisitor
{
    double CalcularImpostoProdutoPerecivel(ProdutoPerecivel produtoPerecivel);
    double CalcularImpostoProdutoNaoPerecivel(ProdutoNaoPerecivel produtoNaoPerecivel);
}
