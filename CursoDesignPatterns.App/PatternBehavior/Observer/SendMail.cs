using DesignPatterns.App.PatternBehavior.Observer.Interfaces;
using DesignPatterns.App.PatternBehavior.Observer.Observers;
using DesignPatterns.App.PatternBehavior.Observer.Subjects;
using System.Globalization;

namespace DesignPatterns.App.PatternBehavior.Observer;

public class SendMail
{
    public void EnviarEmail()
    {
        string msgNaoAssinantes = $"Notamos que aiunda não faz parte, não fique de fora " +
            $"{DateTimeFormatInfo.CurrentInfo.GetMonthName(DateTime.Now.Month)}";

        string msgAssinante = $"Lançamentos para o mês {DateTimeFormatInfo.CurrentInfo.GetMonthName(DateTime.Now.Month)}";

        List<IObservavel> observaveis = new()
        {
            new NaoAssinante(new Model.Pessoa(1, "Diego", "diego@gmail"), msgNaoAssinantes),
            new NaoAssinante(new Model.Pessoa(2, "Murilo", "murilo@gmail"), msgNaoAssinantes),
            new Assinante(new Model.Pessoa(3, "Leila", "leila@gmail"), msgAssinante),
            new Assinante(new Model.Pessoa(4, "Nino", "nino@gmail"), msgAssinante),
        };

        PrimeVideos primeVideos = new();

        foreach (var item in observaveis)
        {
            primeVideos.AddObservavel(item);
        }

        primeVideos.NotificarObservavel();
    }
}
