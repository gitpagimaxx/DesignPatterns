namespace CursoDesignPatterns.App.PatternsCreation.Prototype;

public class PrototypeProgram
{
    public static void Executar()
    {
        GerenciadorVendasStudio gerenciador = new();
        gerenciador["24m"] = new Studio("24M²", "FinanEmpreendimentos", 180000.00M);
        gerenciador["26m"] = new Studio("26M²", "Financiamentos Tabajara", 280000.00M);
        gerenciador["28m"] = new Studio("28M²", "Financiamentos", 380000.00M);

        StudioModel firstClone01 = gerenciador["24m"].Clone();
        StudioModel firstClone02 = gerenciador["26m"].Clone();
        StudioModel firstClone03 = gerenciador["28m"].Clone();
    }
}