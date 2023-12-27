using CursoDesignPatterns.App.PatternsStruture.Decorator.Interfaces;

namespace CursoDesignPatterns.App.PatternsStruture.Decorator.Decorators;

public class AcessorioDecorator : PetDecorator
{
    public AcessorioDecorator(IPet pet) : base(pet)
    {
    }

    public override string GetNomeServico()
    {
        return base.GetNomeServico() + "\n[+] Acessório";
    }

    public override double GetValorServico()
    {
        return base.GetValorServico() + 30.00;
    }
}
