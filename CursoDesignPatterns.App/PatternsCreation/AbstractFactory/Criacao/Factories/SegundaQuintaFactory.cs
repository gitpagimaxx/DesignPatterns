using CursoDesignPatterns.App.PatternsCreation.AbstractFactory.Criacao.Interfaces;
using CursoDesignPatterns.App.PatternsCreation.AbstractFactory.Produto.Produtos.Dietas;
using CursoDesignPatterns.App.PatternsCreation.AbstractFactory.Produto.Produtos.Treinos;

namespace CursoDesignPatterns.App.PatternsCreation.AbstractFactory.Criacao.Factories;

internal class SegundaQuintaFactory : IFactory
{
    public SegundaQuintaFactory()
    {
        this.ObterRotinaDiaria();
    }

    public void ObterRotinaDiaria()
    {
        Console.WriteLine("Factory Segunda e Quinta Criada");
        DietaSegundaQuinta dieta = new DietaSegundaQuinta();
        TreinoSegundaQuinta treino = new TreinoSegundaQuinta();

        dieta.ObterAlimentacao();
        treino.ObterTreino();
    }
}
