using DesignPatterns.App.PatternBehavior.Command.Interfaces;
using DesignPatterns.App.PatternBehavior.Command.Receivers;

namespace DesignPatterns.App.PatternBehavior.Command.Commands;

public class LigaLuminariaCommand : ICommand
{
    private readonly LuzLuminariaReceiver _luzLuminariaReceiver;

    public LigaLuminariaCommand(LuzLuminariaReceiver luzLuminariaReceiver)
    {
        _luzLuminariaReceiver = luzLuminariaReceiver;
    }

    public void Execute()
    {
        _luzLuminariaReceiver.LigarLuz();
    }
}
