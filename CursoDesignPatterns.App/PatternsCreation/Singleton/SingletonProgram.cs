namespace CursoDesignPatterns.App.PatternsCreation.Singleton;

internal class SingletonProgram
{
    public static void Executar()
    {
        var instancia = ContextDB.Instancia;
        instancia.ExecutaQuery("SELECT * FROM Cli...");

        instancia.ExecutaQuery("SELECT * FROM Ped...");

        instancia.ExecutaQuery("SELECT * FROM Est...");
    }
}
