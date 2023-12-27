using CursoDesignPatterns.App.PatternsCreation.Builder.Studios;

namespace CursoDesignPatterns.App.PatternsCreation.Builder.Builders;

internal class Studio26mBuilder : StudioBuilder
{
    public Studio26mBuilder()
    {
        studio = new Studio26m();
    }

    public override void DefinirValorStudio()
    {
        studio.DefinirValorStudio(2800000.00M);
    }

    public override void EscolherFinanciamento()
    {
        studio.EscolherFinanciamento("Invest Fácil Financiamentos");
    }

    public override void EscolherPiso()
    {
        studio.EscolherPiso("Madeira");
    }
}
