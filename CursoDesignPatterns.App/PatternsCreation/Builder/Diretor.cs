using CursoDesignPatterns.App.PatternsCreation.Builder.Builders;

namespace CursoDesignPatterns.App.PatternsCreation.Builder;

internal class Diretor
{
    public void ConstruirStudio(StudioBuilder studioBuilder)
    {
        studioBuilder.DefinirValorStudio();
        studioBuilder.EscolherFinanciamento();
        studioBuilder.EscolherPiso();
    }
}
