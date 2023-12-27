namespace CursoDesignPatterns.App.PatternsCreation.Builder.Studios;

internal class Studio28m : Studio
{
    public override void DefinirValorStudio(decimal valor)
    {
        ValorStudio = valor;
    }

    public override void EscolherFinanciamento(string financiamento)
    {
        TipoFinanciamento = financiamento;
    }

    public override void EscolherPiso(string piso)
    {
        TipoPiso = piso;
    }
}
