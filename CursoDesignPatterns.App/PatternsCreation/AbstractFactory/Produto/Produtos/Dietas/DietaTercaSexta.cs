using CursoDesignPatterns.App.PatternsCreation.AbstractFactory.Produto.Interfaces;

namespace CursoDesignPatterns.App.PatternsCreation.AbstractFactory.Produto.Produtos.Dietas;

public class DietaTercaSexta : IDieta
{
    public DietaTercaSexta()
    {
        //this.ObterAlimentacao();
    }

    public void ObterAlimentacao()
    {
        Console.WriteLine("Dieta Terca e Sexta");
    }
}
