using CursoDesignPatterns.App.PatternsStruture.Proxy.Model;

namespace CursoDesignPatterns.App.PatternsStruture.Proxy.SQL;

internal class DataBaseConnection
{
    public void RegistrarAcessoVPN(User user)
    {
        var query = $"INSERT INTO TB_RegistarVPN (Username, Password, DataHora) VALUES ('{user.Username}', '{user.Password}', {DateTime.Now.ToString("yyyy-MM-dd H:mm:ss")})";

        Console.WriteLine("[!] Registrando acesso pelo proxy...");
        Console.WriteLine(query);
    }
}
