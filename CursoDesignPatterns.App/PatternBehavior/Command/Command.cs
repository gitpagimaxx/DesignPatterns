using DesignPatterns.App.PatternBehavior.Command;
using DesignPatterns.App.PatternBehavior.Command.Commands;
using DesignPatterns.App.PatternBehavior.Command.Receivers;

namespace CursoDesignPatterns.App.PatternBehavior.Command;

public class Command
{
    public static void Executar()
    {
        LuzLuminariaReceiver luminaria = new();
        ControleInvoke controle = new();

        controle.AddCommand("LigaLuz", new LigaLuminariaCommand(luminaria));
        controle.AddCommand("DesligaLuz", new DesligaLuminariaCommand(luminaria));
        controle.AddCommand("AumentaIntesidade", new AumentaIntensidadeCommand(luminaria));
        controle.AddCommand("DiminuirIntensidade", new DiminuiIntensidadeCommand(luminaria));

        controle.ExecuteCommand("LigaLuz");
        controle.ExecuteCommand("LigaLuz");
        controle.ExecuteCommand("AumentaIntesidade");
        controle.ExecuteCommand("DiminuirIntensidade");
        controle.ExecuteCommand("DiminuirIntensidade");
        controle.ExecuteCommand("DiminuirIntensidade");
        controle.ExecuteCommand("DiminuirIntensidade");
        controle.ExecuteCommand("DiminuirIntensidade");
        controle.ExecuteCommand("DiminuirIntensidade");
        controle.ExecuteCommand("AumentaIntesidade");
        controle.ExecuteCommand("AumentaIntesidade");
        controle.ExecuteCommand("AumentaIntesidade");
        controle.ExecuteCommand("AumentaIntesidade");
        controle.ExecuteCommand("AumentaIntesidade");
        controle.ExecuteCommand("DesligaLuz");
        controle.ExecuteCommand("DesligaLuz");

    }
}
