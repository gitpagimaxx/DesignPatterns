using CursoDesignPatterns.App.PatternsCreation.AbstractFactory.Criacao.Interfaces;
using CursoDesignPatterns.App.PatternsCreation.AbstractFactory.Produto.Produtos.Dietas;
using CursoDesignPatterns.App.PatternsCreation.AbstractFactory.Produto.Produtos.Treinos;

namespace CursoDesignPatterns.App.PatternsCreation.AbstractFactory.Criacao.Factories;

internal class QuartaSabadoFactory : IFactory
{
    public QuartaSabadoFactory()
    {
        this.ObterRotinaDiaria();
    }

    public void ObterRotinaDiaria()
    {
        Console.WriteLine("Factory Quarta e Sabado Criada");

        DietaQuartaSabado dieta = new DietaQuartaSabado();
        TreinoQuartaSabado treino = new TreinoQuartaSabado();

        dieta.ObterAlimentacao();
        treino.ObterTreino();
    }
}
