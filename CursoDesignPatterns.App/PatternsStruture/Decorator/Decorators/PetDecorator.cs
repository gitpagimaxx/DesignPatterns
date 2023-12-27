using CursoDesignPatterns.App.PatternsStruture.Decorator.Interfaces;

namespace CursoDesignPatterns.App.PatternsStruture.Decorator.Decorators;

public abstract class PetDecorator : IPet
{
    protected IPet _pet;

    protected PetDecorator(IPet pet)
    {
        _pet = pet;
    }

    public virtual string GetNomeServico()
        => _pet.GetNomeServico();

    public virtual double GetValorServico()
        => _pet.GetValorServico();
    
}
