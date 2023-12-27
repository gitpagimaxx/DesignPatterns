using DesignPatterns.App.PatternBehavior.Command.Interfaces;
using DesignPatterns.App.PatternBehavior.Command.Receivers;

namespace DesignPatterns.App.PatternBehavior.Command.Commands;

public class AumentaIntensidadeCommand : ICommand
{
    private readonly LuzLuminariaReceiver _luzLuminariaReceiver;

    public AumentaIntensidadeCommand(LuzLuminariaReceiver luzLuminariaReceiver)
    {
        _luzLuminariaReceiver = luzLuminariaReceiver;
    }

    public void Execute()
    {
        _luzLuminariaReceiver.AumentarIntensidade();
    }
}
