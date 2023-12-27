using CursoDesignPatterns.App.PatternsCreation.AbstractFactory.Criacao.Interfaces;
using CursoDesignPatterns.App.PatternsCreation.AbstractFactory.Produto.Produtos.Dietas;
using CursoDesignPatterns.App.PatternsCreation.AbstractFactory.Produto.Produtos.Treinos;

namespace CursoDesignPatterns.App.PatternsCreation.AbstractFactory.Criacao.Factories;

internal class TercaSextaFactory : IFactory
{
    public TercaSextaFactory()
    {
        this.ObterRotinaDiaria();
    }

    public void ObterRotinaDiaria()
    {
        Console.WriteLine("Factory Terca e Sexta Criada");
        DietaTercaSexta dieta = new DietaTercaSexta();
        TreinoTercaSexta treino = new TreinoTercaSexta();

        dieta.ObterAlimentacao();
        treino.ObterTreino();
    }
}
