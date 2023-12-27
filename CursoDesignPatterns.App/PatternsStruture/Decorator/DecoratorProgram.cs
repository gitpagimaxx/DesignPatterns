using CursoDesignPatterns.App.PatternsStruture.Decorator.Decorators;
using CursoDesignPatterns.App.PatternsStruture.Decorator.Interfaces;
using CursoDesignPatterns.App.PatternsStruture.Decorator.Services;

namespace CursoDesignPatterns.App.PatternsStruture.Decorator;

internal class DecoratorProgram
{
    public static void Executar()
    {
        IPet banhoTosa = new BanhoTosa("Banho e Tosa", 45.00);

        IPet acessorio = new AcessorioDecorator(banhoTosa);
        IPet luxoSpa = new LuxoSpaDecorator(acessorio);

        Console.WriteLine("Resumo dos serviço de Pet Shop");
        Console.WriteLine(luxoSpa.GetNomeServico());
        Console.WriteLine($"Valor total: {luxoSpa.GetValorServico()}");
    }
}
