using CursoDesignPatterns.App.PatternBehavior.TemplateMethod.Model;

namespace CursoDesignPatterns.App.PatternBehavior.TemplateMethod.AbstractModel;

public abstract class ProcessaDados
{
    protected List<Pessoa> pessoas;
    protected string json;
    protected string xml;

    public ProcessaDados(string json, string xml)
    {
        if (!String.IsNullOrEmpty(xml))
            this.xml = xml;
        else if (!String.IsNullOrEmpty(json))
            this.json = json;

        this.pessoas = new List<Pessoa>();
    }

    public virtual void ProcessarXML()
    { }

    public virtual void ProcessarJSON() 
    { }

    protected void ApresentarValores() 
    {
        foreach (var pessoa in pessoas)
        {
            Console.WriteLine(new String('#', 40));
            Console.WriteLine($"Cliente: {pessoa.Nome}");
            double valorTotal = 0;
            foreach (var item in pessoa.Acoes)
            {
                Console.WriteLine(new String('-', 40));
                valorTotal += item.ValorUnitario * item.Quantidade;
                Console.WriteLine($"Sigla: {item.Sigla}");
                Console.WriteLine($"Valor unitário: {item.ValorUnitario:C}");
                Console.WriteLine($"Quantidade: {item.Quantidade}");
                Console.WriteLine($"Valor total: {valorTotal:C}");
            }
        }
    }
}
