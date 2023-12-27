using DesignPatterns.App.PatternBehavior.ChainOfResponsibilty.AbstractModel;

namespace DesignPatterns.App.PatternBehavior.ChainOfResponsibilty.Receivers;

public class LimpezaReceiver : CobrancaReceiver
{
    public override Checkout ExecutarCobrancaServico(Checkout checkout)
    {
        Console.WriteLine("Realizando a cobrança taxa de limpeza...");
        checkout.ValorTotal += (checkout.ValorTotal * 0.025);
        Thread.Sleep(1500);

        return base.ExecutarCobrancaServico(checkout);
    }
}
