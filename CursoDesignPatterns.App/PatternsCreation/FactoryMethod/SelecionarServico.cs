using CursoDesignPatterns.App.PatternsCreation.FactoryMethod.Enums;
using CursoDesignPatterns.App.PatternsCreation.FactoryMethod.Interfaces;
using CursoDesignPatterns.App.PatternsCreation.FactoryMethod.Services;

namespace CursoDesignPatterns.App.PatternsCreation.FactoryMethod;

public class SelecionarServico : ServicoFactory
{
    public override IServico GetServico(ETipoServicos eTipoServicos)
    {
        IServico servico = eTipoServicos switch
        {
            ETipoServicos.tradicional => new TradicionalServico(),
            ETipoServicos.premium => new PremiumServico(),
            ETipoServicos.master => new MasterServico(),
            ETipoServicos.cobertura => new CoberturaServico(),
            _ => throw new NotImplementedException()
        };

        return servico;
    }
}
