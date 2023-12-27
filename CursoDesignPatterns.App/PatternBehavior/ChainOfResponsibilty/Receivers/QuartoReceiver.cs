using DesignPatterns.App.PatternBehavior.ChainOfResponsibilty.AbstractModel;

namespace DesignPatterns.App.PatternBehavior.ChainOfResponsibilty.Receivers;

public class QuartoReceiver : CobrancaReceiver
{
    public override Checkout ExecutarCobrancaServico(Checkout checkout)
    {
        Console.WriteLine("Realizando a cobrança taxa de serviço de quarto...");
        checkout.ValorTotal += (checkout.ValorTotal * 0.03);
        Thread.Sleep(1500);

        return base.ExecutarCobrancaServico(checkout);
    }
}
