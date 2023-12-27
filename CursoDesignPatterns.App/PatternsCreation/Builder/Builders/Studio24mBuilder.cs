using CursoDesignPatterns.App.PatternsCreation.Builder.Studios;

namespace CursoDesignPatterns.App.PatternsCreation.Builder.Builders;

internal class Studio24mBuilder : StudioBuilder
{
    public Studio24mBuilder()
    {
        studio = new Studio24m();
    }

    public override void DefinirValorStudio()
    {
        studio.DefinirValorStudio(1800000.00M);
    }

    public override void EscolherFinanciamento()
    {
        studio.EscolherFinanciamento("FinaMovelFinanciamentos");
    }

    public override void EscolherPiso()
    {
        studio.EscolherPiso("Porcelanato");
    }
}
