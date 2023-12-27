using DesignPatterns.App.PatternBehavior.Strategy.Interfaces;
using DesignPatterns.App.PatternBehavior.Strategy.Model;

namespace DesignPatterns.App.PatternBehavior.Strategy.Services;

public class MasterServico : IServico
{
    private readonly Orcamento _orcamento;

    public MasterServico(Orcamento orcamento)
    {
        _orcamento = orcamento;
    }

    public void CalcularServico()
    {
        var porcentagem = _orcamento.ValorTotal * ((double)_orcamento.Porcentagem / 100);
        _orcamento.ValorTotal += porcentagem;

        if (_orcamento.CupomDesconto)
        {
            Console.WriteLine($"Valor sem desconto {_orcamento.ValorTotal:C}");
            _orcamento.ValorTotal -= _orcamento.ValorTotal * 0.02;
            Console.WriteLine($"Cupom de desconto de 2% para suite master");
            Console.WriteLine();
        }

        else if (_orcamento.CupomDesconto && _orcamento.Quantidade > 60)
        {
            Console.WriteLine($"Valor sem desconto {_orcamento.ValorTotal:C}");
            _orcamento.ValorTotal -= _orcamento.ValorTotal * 0.03;
            Console.WriteLine($"Conta superior a 60 e cupom de desconto recebe 3% de desconto para a Master");
            Console.WriteLine();
        }

        Console.WriteLine($"Tipo de Quarto: {_orcamento.Porcentagem}");
        Console.WriteLine($"Porcentagem do Serviço: {porcentagem:C}");
        Console.WriteLine($"Quantidade Dias: {_orcamento.Quantidade}");
        Console.WriteLine($"Valor Dia: {_orcamento.ValorDiaria}");
        Console.WriteLine($"Valor Total: {_orcamento.ValorTotal}");
    }
}
