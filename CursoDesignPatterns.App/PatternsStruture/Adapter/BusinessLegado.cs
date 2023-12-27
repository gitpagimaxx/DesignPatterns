namespace CursoDesignPatterns.App.PatternsStruture.Adapter;

internal class BusinessLegado
{
    public string ExecutarRotinaContasPagar(string mes)
    {
        var result = AcessoSQL.GetDadosPagar(mes);
        Console.WriteLine("Processando regras de contas a pagar...");
        Thread.Sleep(3000);
        
        return result;
    }

    public string ExecutarRotinaContasReceber(string mes)
    {
        var result = AcessoSQL.GetDadosReceber(mes);
        Console.WriteLine("Processando regras de contas a receber...");
        Thread.Sleep(3000);

        return result;
    }
}
