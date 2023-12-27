using CursoDesignPatterns.App.PatternsCreation.FactoryMethod.Interfaces;

namespace CursoDesignPatterns.App.PatternsCreation.FactoryMethod.Services;

public class TradicionalServico : IServico
{
    public TradicionalServico()
    {
        Console.WriteLine("Produto Tradicional criado com sucesso");
    }

    public void ExecutaCobrancaServico()
    {
        throw new NotImplementedException();
    }
}
