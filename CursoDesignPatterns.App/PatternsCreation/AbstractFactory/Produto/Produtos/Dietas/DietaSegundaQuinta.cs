using CursoDesignPatterns.App.PatternsCreation.AbstractFactory.Produto.Interfaces;

namespace CursoDesignPatterns.App.PatternsCreation.AbstractFactory.Produto.Produtos.Dietas;

public class DietaSegundaQuinta : IDieta
{
    public DietaSegundaQuinta()
    {
        //this.ObterAlimentacao();
    }

    public void ObterAlimentacao()
    {
        Console.WriteLine("D - Dieta Segunda e Quinta");
    }
}
