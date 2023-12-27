using CursoDesignPatterns.App.PatternsCreation.AbstractFactory.Produto.Interfaces;

namespace CursoDesignPatterns.App.PatternsCreation.AbstractFactory.Produto.Produtos.Dietas;

public class DietaQuartaSabado : IDieta
{
    public DietaQuartaSabado()
    {
        //this.ObterAlimentacao();
    }
    
    public void ObterAlimentacao()
    {
        Console.WriteLine("Dieta Quarta e Sabado");
    }
}
