using CursoDesignPatterns.App.PatternsCreation.Builder.Studios;

namespace CursoDesignPatterns.App.PatternsCreation.Prototype;

public class Studio : StudioModel
{
    private string _tipoStudio;
    private string _tipoFinanciamento;
    private decimal _valorStudio;

    public Studio(string tipoStudio, string tipoFinanciamento, decimal valorStudio)
    {
        _tipoStudio = tipoStudio;
        _tipoFinanciamento = tipoFinanciamento;
        _valorStudio = valorStudio;
    }

    public override StudioModel? Clone()
    {
        Console.WriteLine(new string('-', 40));
        Console.WriteLine($"Studio: {_tipoStudio}");
        Console.WriteLine($"Valor: {_valorStudio:C}");
        Console.WriteLine($"Financiamento: {_tipoFinanciamento}");

        return this.MemberwiseClone() as StudioModel;
    }
}
