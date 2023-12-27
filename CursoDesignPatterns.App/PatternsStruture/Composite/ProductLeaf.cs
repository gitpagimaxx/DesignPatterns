using CursoDesignPatterns.App.PatternsStruture.Composite.Model;

namespace CursoDesignPatterns.App.PatternsStruture.Composite;

public class ProductLeaf : ComponentModel
{
    private string _nome;
    private double _valor;

    public ProductLeaf(string nome, double valor)
    {
        _nome = nome;
        _valor = valor;
    }

    public override void Add(params ComponentModel[] components)
    {
        Console.WriteLine("Não é possível adicionar objetos em um objeto do tipo Leaf");
    }

    public override ComponentModel GetChild(int index)
    {
        Console.WriteLine("Não é possível obter itens em um objeto do tipo Leaf");
        return null;
    }

    public override double Operation()
    {
        Console.WriteLine($"Produto: {_nome}");
        Console.WriteLine($"Valor: {_valor:C}");
        Console.WriteLine(new String('-', 40));
        return _valor;
    }

    public override void Remove(ComponentModel component)
    {
        Console.WriteLine("Não é possível remover em um objeto do tipo Leaf");
    }
}
