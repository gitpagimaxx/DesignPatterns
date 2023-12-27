using CursoDesignPatterns.App.PatternsStruture.Decorator.Interfaces;

namespace CursoDesignPatterns.App.PatternsStruture.Decorator.Decorators;

public class LuxoSpaDecorator : PetDecorator
{
    public LuxoSpaDecorator(IPet pet) : base(pet)
    {
    }

    public override string GetNomeServico()
    {
        return base.GetNomeServico() + "\n[+] Luxo Spa";
    }

    public override double GetValorServico()
    {
        return base.GetValorServico() + 200.00;
    }
}
