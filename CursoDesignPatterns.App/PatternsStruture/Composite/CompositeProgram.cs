using CursoDesignPatterns.App.PatternsStruture.Composite.Model;

namespace CursoDesignPatterns.App.PatternsStruture.Composite;

public class CompositeProgram
{
    public void Executar()
    {
        ComponentModel product1 = new ProductLeaf("Caneca Batman", 30.00);
        ComponentModel product2 = new ProductLeaf("Camiseta Star Trek", 60.00);
        ComponentModel product3 = new ProductLeaf("Pantufa Chewbaca", 90.00);
        ComponentModel product4 = new ProductLeaf("Action Figure", 120.00);

        ComponentModel smallBox = new ProductComposite();
        smallBox.Add(product1, product2, product3);

        ComponentModel bigBox = new ProductComposite();
        bigBox.Add(smallBox, product4);

        var valorTotal = bigBox.Operation();

        Console.WriteLine(new String('-', 40));
        Console.WriteLine($"Valor total {valorTotal:C}");
    }
}
