using CursoDesignPatterns.App.PatternsCreation.AbstractFactory.Produto.Interfaces;

namespace CursoDesignPatterns.App.PatternsCreation.AbstractFactory.Produto.Produtos.Treinos;

public class TreinoQuartaSabado : ITreino
{
    public TreinoQuartaSabado()
    {
        //this.ObterTreino();
    }

    public void ObterTreino()
    {
        Console.WriteLine("Treino Quarta e Sabado");
    }
}
