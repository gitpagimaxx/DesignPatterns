using DesignPatterns.App.PatternBehavior.Command.Interfaces;

namespace DesignPatterns.App.PatternBehavior.Command;

public class ControleInvoke
{
    private Dictionary<string, ICommand> Commands = new Dictionary<string, ICommand>();

    public void AddCommand(string key, ICommand command)
    {
        Commands.Add(key, command);
    }

    public void ExecuteCommand(string key)
    {
        if (!Commands.ContainsKey(key))
            Console.WriteLine($"Comando inexistente");
        else
            this.Commands[key].Execute();
    }
}
