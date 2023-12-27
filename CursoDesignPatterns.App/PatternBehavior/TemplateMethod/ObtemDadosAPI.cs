using CursoDesignPatterns.App.PatternBehavior.TemplateMethod.Model;
using System.Text.Json;
using System.Xml.Serialization;

namespace CursoDesignPatterns.App.PatternBehavior.TemplateMethod;

public class ObtemDadosAPI
{
    public static string EndpointXML()
    {
        var pessoas = GetPessoas();
        XmlSerializer serializer = new(pessoas.GetType());
        string xml = String.Empty;

        using(var sw = new StringWriter())
        {
            serializer.Serialize(sw, pessoas);
            xml = sw.ToString();
        }

        return xml;
    }

    public static string EndpointJSON()
    {
        var pessoas = GetPessoas();
        var options = new JsonSerializerOptions { WriteIndented = true };
        var json = JsonSerializer.Serialize(pessoas, options);
        return json;
    }

    private static List<Pessoa> GetPessoas()
    {
        return new List<Pessoa>()
        {
            new Pessoa()
            {
                Nome = "Diego",
                CPF = "123.456.789-10",
                Acoes = new List<Acoes>()
                {
                    new Acoes("AAAA3", 50, 15.44),
                    new Acoes("BBBB3", 80, 22.34)
                }
            },
            new Pessoa()
            {
                Nome = "Murilo",
                CPF = "321.654.987-01",
                Acoes = new List<Acoes>()
                {
                    new Acoes("AAAA3", 30, 15.44),
                    new Acoes("BBBB3", 70, 22.34)
                }
            }
        };
    }
}
