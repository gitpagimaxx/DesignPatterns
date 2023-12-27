using CursoDesignPatterns.App.PatternsCreation.FactoryMethod.Interfaces;

namespace CursoDesignPatterns.App.PatternsCreation.FactoryMethod.Services;

public class PremiumServico : IServico
{
    public PremiumServico()
    {
        Console.WriteLine("Produto Premium criado com sucesso");
    }

    public void ExecutaCobrancaServico()
    {
        throw new NotImplementedException();
    }
}
