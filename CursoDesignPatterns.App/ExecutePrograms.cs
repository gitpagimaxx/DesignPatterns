
namespace CursoDesignPatterns.App;

public class ExecutePrograms
{
    readonly Dictionary<string, Action> programas;

    public ExecutePrograms(Dictionary<string, Action> _programas)
    {
        programas = _programas;
    }

    public void SelecionarEExecutar()
    {
        int i = 1;

        foreach (var item in programas)
        {
            Console.WriteLine("{0}) {1}", i, item.Key);
            i++;
        }

        Console.Write("Digite o número (ou vazio para o último)? ");

        int.TryParse(Console.ReadLine(), out int num);
        bool numValido = num > 0 && num <= programas.Count;
        num = numValido ? num - 1 : programas.Count - 1;

        string nomeDoPrograma = programas.ElementAt(num).Key;

        Console.Write("\nExecutando exercício ");
        Console.BackgroundColor = ConsoleColor.Yellow;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine(nomeDoPrograma);
        Console.ResetColor();

        Console.WriteLine(String.Concat(
            Enumerable.Repeat("=", nomeDoPrograma.Length + 21)) + "\n");

        Action executar = programas.ElementAt(num).Value;
        try
        {
            executar();
        }
        catch (Exception e)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Ocorreu um erro: {0}", e.Message);
            Console.ResetColor();

            Console.WriteLine(e.StackTrace);
        }
    }
}
