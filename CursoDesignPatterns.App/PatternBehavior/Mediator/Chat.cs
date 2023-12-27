namespace DesignPatterns.App.PatternBehavior.Mediator;

public class Chat
{
    public static void Conversar()
    {
        MediadorConcreto mediador = new();
        Atendente atendente = new(mediador);
        Paciente paciente = new(mediador);

        mediador.Atendente = atendente;
        mediador.Paciente = paciente;

        Console.WriteLine($"Chat iniciado em {DateTime.Now}");
        Console.WriteLine();

        paciente.EnviarMensagem("Por favor, eu gostaria de agendar uma consulta");
        atendente.EnviarMensagem("Sim, qual especialidade?");

        paciente.EnviarMensagem("Clinico Geral");
        atendente.EnviarMensagem("Temos vagas para a próxima terça nos horários ...");

        paciente.EnviarMensagem("Pode agendar para terça ...");
        atendente.EnviarMensagem("Agendamento concluído com sucesso");

        paciente.EnviarMensagem("Obrigado...");
        atendente.EnviarMensagem("Nós que agradecemos");

        Console.WriteLine();
        Console.WriteLine($"Chat finalizado em {DateTime.Now}");

    }
}