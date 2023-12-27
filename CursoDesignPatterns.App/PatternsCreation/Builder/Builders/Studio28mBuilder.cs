using CursoDesignPatterns.App.PatternsCreation.Builder.Studios;

namespace CursoDesignPatterns.App.PatternsCreation.Builder.Builders;

internal class Studio28mBuilder : StudioBuilder
{
    public Studio28mBuilder()
    {
        studio = new Studio28m();
    }

    public override void DefinirValorStudio()
    {
        studio.DefinirValorStudio(3800000.00M);
    }

    public override void EscolherFinanciamento()
    {
        studio.EscolherFinanciamento("Koch Tavares");
    }

    public override void EscolherPiso()
    {
        studio.EscolherPiso("Marmore");
    }
}
