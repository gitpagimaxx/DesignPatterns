using CursoDesignPatterns.App.PatternsCreation.AbstractFactory.Produto.Interfaces;

namespace CursoDesignPatterns.App.PatternsCreation.AbstractFactory.Produto.Produtos.Treinos;

public class TreinoTercaSexta : ITreino
{
    public TreinoTercaSexta()
    {
        //this.ObterTreino();
    }

    public void ObterTreino()
    {
        Console.WriteLine("Treino Terca e Sexta");
    }
}
