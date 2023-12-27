using DesignPatterns.App.PatternBehavior.ChainOfResponsibilty.Receivers;

namespace DesignPatterns.App.PatternBehavior.ChainOfResponsibilty;

public class Sender
{
    public static void RealizarCheckout()
    {
        Checkout checkout = new(1001, 23, 23.50);
        Console.WriteLine("Valores:");
        Console.WriteLine($"Sem taxas {checkout.ValorTotal:C}");

        var lavanderia = new LanvanderiaReceiver();
        var quarto = new QuartoReceiver();
        var limpeza = new LimpezaReceiver();

        lavanderia.AddNext(quarto);
        quarto.AddNext(limpeza);

        lavanderia.ExecutarCobrancaServico(checkout);

        Console.WriteLine($"Com taxas {checkout.ValorTotal:C}");
        Console.WriteLine(new string('-', 40));
    }
}
