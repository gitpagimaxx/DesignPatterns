using CursoDesignPatterns.App.PatternsStruture.Proxy.Model;

namespace CursoDesignPatterns.App.PatternsStruture.Proxy;

internal class ProxyProgram
{
    public static void Executar()
    {
        VPNProxy proxy = new();

        Console.Write("Digite o username: ");
        string username = Console.ReadLine();

        Console.Write("Digite a senha: ");
        string password = Console.ReadLine();

        var user = new User(username, password);
        proxy.AcessarVPN(user);
    }
}
