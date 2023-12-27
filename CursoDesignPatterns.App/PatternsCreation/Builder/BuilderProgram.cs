using CursoDesignPatterns.App.PatternsCreation.Builder.Builders;
using CursoDesignPatterns.App.PatternsCreation.Builder.Studios;

namespace CursoDesignPatterns.App.PatternsCreation.Builder;

internal class BuilderProgram
{
    public static void Executar()
    {
        Diretor diretor = new Diretor();
        StudioBuilder studioBuilder;
        Studio studio;

        studioBuilder = new Studio24mBuilder();
        diretor.ConstruirStudio(studioBuilder);
        studio = studioBuilder.GetStudio();
        ImprimirResultado(studio, "24M²");

        studioBuilder = new Studio26mBuilder();
        diretor.ConstruirStudio(studioBuilder);
        studio = studioBuilder.GetStudio();
        ImprimirResultado(studio, "26M²");

        studioBuilder = new Studio28mBuilder();
        diretor.ConstruirStudio(studioBuilder);
        studio = studioBuilder.GetStudio();
        ImprimirResultado(studio, "28M²");
    }

    private static void ImprimirResultado(Studio studio, string nome)
    {
        Console.WriteLine(new String('-', 40));
        Console.WriteLine($"[+] Studio {nome}");
        Console.WriteLine($"Valor: {studio.ValorStudio:C}");
        Console.WriteLine($"Piso: {studio.TipoPiso}");
        Console.WriteLine($"Financiamento: {studio.TipoFinanciamento}");
    }
}
