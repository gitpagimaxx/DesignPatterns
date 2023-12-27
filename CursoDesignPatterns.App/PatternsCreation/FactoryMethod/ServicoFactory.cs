using CursoDesignPatterns.App.PatternsCreation.FactoryMethod.Enums;
using CursoDesignPatterns.App.PatternsCreation.FactoryMethod.Interfaces;

namespace CursoDesignPatterns.App.PatternsCreation.FactoryMethod
{
    public abstract class ServicoFactory
    {
        public abstract IServico GetServico(ETipoServicos eTipoServicos);
    }
}
