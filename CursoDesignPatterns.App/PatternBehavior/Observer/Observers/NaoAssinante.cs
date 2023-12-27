using DesignPatterns.App.PatternBehavior.Observer.Interfaces;
using DesignPatterns.App.PatternBehavior.Observer.Model;

namespace DesignPatterns.App.PatternBehavior.Observer.Observers;

public class NaoAssinante : IObservavel
{
    public NaoAssinante(Pessoa pessoa, string mensagem)
    {
        Pessoa = pessoa;
        Mensagem = mensagem;
    }

    public Pessoa Pessoa { get; set; }
    public string Mensagem { get; set; }

    public void Update()
    {
        Console.WriteLine($"Enviando e-mail para {Pessoa.Email}");
        Console.WriteLine($"Prezado {Pessoa.Nome}!");
        Console.WriteLine($"Mensagem: {Mensagem}");

        Console.WriteLine($"INSERT TB_Notificacao... {DateTime.Now.Month}");
    }
}
