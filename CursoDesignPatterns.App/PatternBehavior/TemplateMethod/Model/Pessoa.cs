namespace CursoDesignPatterns.App.PatternBehavior.TemplateMethod.Model;

public class Pessoa
{
    public Pessoa()
    {
        
    }

    public string Nome { get; set; }
    public string CPF { get; set; }

    public List<Acoes> Acoes { get; set; }
}
