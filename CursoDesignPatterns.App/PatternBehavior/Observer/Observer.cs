using DesignPatterns.App.PatternBehavior.Observer;

namespace CursoDesignPatterns.App.PatternBehavior.Observer;

public class Observer
{
    public static void Executar()
    {
        new SendMail().EnviarEmail();
    }
}
