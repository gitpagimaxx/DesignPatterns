using DesignPatterns.App.PatternBehavior.Command.Interfaces;
using DesignPatterns.App.PatternBehavior.Command.Receivers;

namespace DesignPatterns.App.PatternBehavior.Command.Commands;

public class DesligaLuminariaCommand : ICommand
{
    private readonly LuzLuminariaReceiver _luzLuminariaReceiver;

    public DesligaLuminariaCommand(LuzLuminariaReceiver luzLuminariaReceiver)
    {
        _luzLuminariaReceiver = luzLuminariaReceiver;
    }

    public void Execute()
    {
        _luzLuminariaReceiver.DesligarLuz();
    }
}
