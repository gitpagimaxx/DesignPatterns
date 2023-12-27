using DesignPatterns.App.PatternBehavior.Strategy.Interfaces;
using DesignPatterns.App.PatternBehavior.Strategy.Model;

namespace DesignPatterns.App.PatternBehavior.Strategy.Services;

public class CoberturaServico : IServico
{
    private readonly Orcamento _orcamento;

    public CoberturaServico(Orcamento orcamento)
    {
        _orcamento = orcamento;
    }

    public void CalcularServico()
    {
        var porcentagem = _orcamento.ValorTotal * ((double)_orcamento.Porcentagem / 100);
        _orcamento.ValorTotal += porcentagem;

        if (_orcamento.Quantidade > 60) 
        {
            Console.WriteLine($"Valor sem desconto {_orcamento.ValorTotal:C}");
            _orcamento.ValorTotal -= _orcamento.ValorTotal * 0.03;
            Console.WriteLine($"Conta superior a 60 recebe 3% de desconto para a cobertura");
            Console.WriteLine();
        }

        Console.WriteLine($"Tipo de Quarto: {_orcamento.Porcentagem}");
        Console.WriteLine($"Porcentagem do Serviço: {porcentagem:C}");
        Console.WriteLine($"Quantidade Dias: {_orcamento.Quantidade}");
        Console.WriteLine($"Valor Dia: {_orcamento.ValorDiaria}");
        Console.WriteLine($"Valor Total: {_orcamento.ValorTotal}");

    }
}
