using DesignPatterns.App.PatternBehavior.ChainOfResponsibilty.AbstractModel;

namespace DesignPatterns.App.PatternBehavior.ChainOfResponsibilty.Receivers;

public class LanvanderiaReceiver : CobrancaReceiver
{
    public override Checkout ExecutarCobrancaServico(Checkout checkout)
    {
        Console.WriteLine("Realizando a cobrança taxa de lavanderia...");
        checkout.ValorTotal += (checkout.ValorTotal * 0.028);
        Thread.Sleep(1500);

        return base.ExecutarCobrancaServico(checkout);
    }
}
