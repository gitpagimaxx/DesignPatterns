using CursoDesignPatterns.App.PatternsCreation.AbstractFactory.Criacao.Factories;
using CursoDesignPatterns.App.PatternsCreation.AbstractFactory.Criacao.Interfaces;

namespace CursoDesignPatterns.App.PatternsCreation.AbstractFactory;

public class AbstractFactoryProgram
{
    public static void Executar()
    {
        var continuar = true;

        while (continuar) 
        {
            IFactory factory;

            Console.WriteLine("Selecione a rotina");
            Console.WriteLine("1 - Segunda e Quinta");
            Console.WriteLine("2 - Terça e Sexta");
            Console.WriteLine("3 - Quarta e Sábado");

            Console.Write("Digite o número desejado: ");
            _ = int.TryParse(Console.ReadLine(), out int escolha);

            factory = escolha switch
            {
                1 => new SegundaQuintaFactory(),
                2 => new TercaSextaFactory(),
                3 => new QuartaSabadoFactory(),
                _ => throw new NotImplementedException()
            };

            Console.Write("Deseja continuar? (1 - Sim / 2 - Não): ");
            _ = int.TryParse(Console.ReadLine(), out int resp);

            continuar = resp == 1;
        }
    }
}
