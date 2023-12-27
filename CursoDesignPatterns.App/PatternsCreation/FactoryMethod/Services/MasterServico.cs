using CursoDesignPatterns.App.PatternsCreation.FactoryMethod.Interfaces;

namespace CursoDesignPatterns.App.PatternsCreation.FactoryMethod.Services;

public class MasterServico : IServico
{
    public MasterServico()
    {
        Console.WriteLine("Produto Master criado com sucesso");
    }

    public void ExecutaCobrancaServico()
    {
        throw new NotImplementedException();
    }
}
