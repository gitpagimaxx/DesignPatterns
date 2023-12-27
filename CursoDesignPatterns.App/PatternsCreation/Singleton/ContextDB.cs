namespace CursoDesignPatterns.App.PatternsCreation.Singleton;

public class ContextDB
{
    private static ContextDB _instancia = null;

    private ContextDB()
    {
    }

    public static ContextDB Instancia 
    { 
        get
        {
            if (_instancia == null)
            {
                _instancia = new ContextDB();
                Console.WriteLine("Instancia criada");
            }

            return _instancia;
        }
    }

    public void ExecutaQuery(string query)
    {
        Console.WriteLine(query);
    }
}
