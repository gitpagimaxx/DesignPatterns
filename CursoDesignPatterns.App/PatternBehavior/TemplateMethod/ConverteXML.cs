using CursoDesignPatterns.App.PatternBehavior.TemplateMethod.AbstractModel;
using CursoDesignPatterns.App.PatternBehavior.TemplateMethod.Model;
using System.Xml;
using System.Xml.Serialization;

namespace CursoDesignPatterns.App.PatternBehavior.TemplateMethod;

public class ConverteXML : ProcessaDados
{
    public ConverteXML(string xml) : base("", xml)
    {

    }

    public override void ProcessarXML()
    {
        XmlSerializer serializer = new XmlSerializer(this.pessoas.GetType());
        var stringReader = new StringReader(this.xml);

        using(var reader = XmlReader.Create(stringReader))
        {
            this.pessoas = (List<Pessoa>)serializer.Deserialize(reader);
        }

        this.ApresentarValores();
    }
}
