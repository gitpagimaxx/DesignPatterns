using DesignPatterns.App.PatternBehavior.Visitor.Interfaces;
using DesignPatterns.App.PatternBehavior.Visitor.Produtos;
using DesignPatterns.App.PatternBehavior.Visitor.Visitors;

namespace DesignPatterns.App.PatternBehavior.Visitor;

public class Fiscal
{
    private static List<IVisitor> GetVisitors() => new List<IVisitor>()
    {
        new SaoPauloVisitor(), new RioDeJaneiroVisitor(),
    };

    public void CalcularImposto()
    {
        CalcularProdutosPereciveis();
        Console.WriteLine(new String('-', 40));
        CalcularProdutosNaoPereciveis();
    }

    private static void CalcularProdutosNaoPereciveis()
    {
        List<ProdutoNaoPerecivel> produtoNaoPerecivels = new()
        {
            new ProdutoNaoPerecivel("Antena Wi-fi", 500),
            new ProdutoNaoPerecivel("Perfume Boticario", 1000),
        };

        Console.WriteLine("Calculando imposto de produtos NÃO perecíveis...");

        foreach (var item in produtoNaoPerecivels)
        {
            Console.WriteLine($"Produto: {item.Nome} - Peso: {item.Peso}");
            
            foreach (var visitor in GetVisitors())
            {
                visitor.CalcularImpostoProdutoNaoPerecivel(item);
            }

            Console.WriteLine();
            Thread.Sleep(1500);
        }
    }

    private static void CalcularProdutosPereciveis()
    {
        List<ProdutoPerecivel> produtoPerecivels = new()
        {
            new ProdutoPerecivel("Sorvete", 2500),
            new ProdutoPerecivel("Pão Italiano", 2000),
        };

        Console.WriteLine("Calculando imposto de produtos perecíveis...");

        foreach (var item in produtoPerecivels)
        {
            Console.WriteLine($"Produto: {item.Nome} - Peso: {item.Peso}");

            foreach (var visitor in GetVisitors())
            {
                visitor.CalcularImpostoProdutoPerecivel(item);
            }

            Console.WriteLine();
            Thread.Sleep(1500);
        }
    }
}
