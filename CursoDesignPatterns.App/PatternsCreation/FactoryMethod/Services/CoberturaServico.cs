using CursoDesignPatterns.App.PatternsCreation.FactoryMethod.Interfaces;

namespace CursoDesignPatterns.App.PatternsCreation.FactoryMethod.Services;

public class CoberturaServico : IServico
{
    public CoberturaServico()
    {
        Console.WriteLine("Produto Cobertura criado com sucesso");
    }

    public void ExecutaCobrancaServico()
    {
        throw new NotImplementedException();
    }
}
