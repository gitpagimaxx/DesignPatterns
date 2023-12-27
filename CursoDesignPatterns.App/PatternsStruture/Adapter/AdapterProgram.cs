using CursoDesignPatterns.App.PatternsStruture.Adapter;

namespace CursoDesignPatterns.App.PatternsStructure.Adapter;

public class AdapterProgram
{
    public static void Executar()
    {
        CloudComputing cloud = new();
        cloud.ProcessarContas("junho");
    }
}