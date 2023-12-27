namespace CursoDesignPatterns.App.PatternBehavior.TemplateMethod;

public class TemplateMethodProgram
{
    public static void Executar()
    {
        ConsumirEndpointXML();
        ConsumirEndpointJSON();
    }

    public static void ConsumirEndpointXML()
    {
        Console.WriteLine("");
        Console.WriteLine("---------- XML ----------");
        var xml = ObtemDadosAPI.EndpointXML();
        ConverteXML converteXML = new(xml);
        converteXML.ProcessarXML();
    }

    public static void ConsumirEndpointJSON()
    {
        Console.WriteLine("");
        Console.WriteLine("---------- JSON ----------");
        var json = ObtemDadosAPI.EndpointJSON();
        ConverteJSON converte = new(json);
        converte.ProcessarJSON();
    }
}