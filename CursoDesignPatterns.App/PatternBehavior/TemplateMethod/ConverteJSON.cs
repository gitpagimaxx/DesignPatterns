using CursoDesignPatterns.App.PatternBehavior.TemplateMethod.AbstractModel;
using CursoDesignPatterns.App.PatternBehavior.TemplateMethod.Model;
using System.Text.Json;

namespace CursoDesignPatterns.App.PatternBehavior.TemplateMethod;

public class ConverteJSON : ProcessaDados
{
    public ConverteJSON(string json) : base(json, "") { }

    public override void ProcessarJSON()
    {
        this.pessoas = JsonSerializer.Deserialize<List<Pessoa>>(this.json);
        this.ApresentarValores();
    }
}
