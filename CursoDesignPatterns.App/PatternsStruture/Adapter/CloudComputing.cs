using CursoDesignPatterns.App.PatternsStruture.Adapter.Interfaces;

namespace CursoDesignPatterns.App.PatternsStruture.Adapter;

internal class CloudComputing
{
    readonly IAdapter adapter;

    public CloudComputing()
    {
        this.adapter = new Adapter(new BusinessLegado());
    }

    public void ProcessarContas(string mes)
    {
        var result = this.adapter.ExecutarRotinaContasPagar(mes);
        Console.WriteLine("Processando camada Cloud Computing conta a pagar");
        Console.WriteLine(result);
        Thread.Sleep(3000);

        Console.WriteLine(new string('-', 40));
        result = this.adapter.ExecutarRotinaContasPagar(mes);
        Console.WriteLine("Processando camada Cloud Computing conta a receber");
        Console.WriteLine(result);
        Thread.Sleep(3000);

        Console.WriteLine("\nProcesso finalizado com sucesso");
    }
}
