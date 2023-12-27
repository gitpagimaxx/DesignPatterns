using DesignPatterns.App.PatternBehavior.Strategy.Interfaces;
using DesignPatterns.App.PatternBehavior.Strategy.Model;
using DesignPatterns.App.PatternBehavior.Strategy.Services;

namespace DesignPatterns.App.PatternBehavior.Strategy;

public class RotinaTaxaServico
{
    public static void ExecutarRotina()
    {
        var cobertura01 = new Orcamento(01, 70, 30, Enum.PorcentagemServicos.Cobertura);
        var cobertura02 = new Orcamento(02, 70, 65, Enum.PorcentagemServicos.Cobertura);

        var master01 = new Orcamento(03, 50, 20, Enum.PorcentagemServicos.Master, true);
        var master02 = new Orcamento(04, 50, 15, Enum.PorcentagemServicos.Master, true);
        var master03 = new Orcamento(05, 70, 65, Enum.PorcentagemServicos.Master);

        var premium01 = new Orcamento(06, 40, 23, Enum.PorcentagemServicos.Premium, true);
        var premium02 = new Orcamento(07, 40, 23, Enum.PorcentagemServicos.Premium);

        var tradicional01 = new Orcamento(08, 40, 20, Enum.PorcentagemServicos.Tradicional);
        var tradicional02 = new Orcamento(09, 40, 32, Enum.PorcentagemServicos.Tradicional, true);

        var orcamentosServicos = new List<IServico>()
        {
            new CoberturaServico(cobertura01),
            new CoberturaServico(cobertura02),
            new MasterServico(master01),
            new MasterServico(master02),
            new MasterServico(master03),
            new PremiumServico(premium01),
            new PremiumServico(premium02),
            new TradicionalServico(tradicional01),
            new TradicionalServico(tradicional02),
        };

        CalculaTaxaServico.Calcular(orcamentosServicos);
    }
}
