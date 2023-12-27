using CursoDesignPatterns.App.PatternsCreation.AbstractFactory.Produto.Interfaces;

namespace CursoDesignPatterns.App.PatternsCreation.AbstractFactory.Produto.Produtos.Treinos;

public class TreinoSegundaQuinta : ITreino
{
    public TreinoSegundaQuinta()
    {
        //this.ObterTreino();    
    }

    public void ObterTreino()
    {
        Console.WriteLine("T - Treino Segunda e Quinta");
    }
}
