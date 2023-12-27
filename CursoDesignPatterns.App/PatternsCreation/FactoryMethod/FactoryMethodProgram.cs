using CursoDesignPatterns.App.PatternsCreation.FactoryMethod.Enums;

namespace CursoDesignPatterns.App.PatternsCreation.FactoryMethod;

internal class FactoryMethodProgram
{
    public static void Executar()
    {
        var cliente = new SelecionarServico();
        var continuar = true;

        while (continuar)
        {
            Console.WriteLine("Selecione o tipo de serviço");
            Console.WriteLine("1 - Tradicional");
            Console.WriteLine("2 - Premium");
            Console.WriteLine("3 - Master");
            Console.WriteLine("4 - Cobertura");

            Console.Write("Digite o número do serviço que deseja cobrar: ");
            _ = int.TryParse(Console.ReadLine(), out int tipoServico);
            _ = cliente.GetServico((ETipoServicos)tipoServico);

            Console.Write("Deseja calcular outro serviço? (1-Sim ou 2-Não): ");
            _ = int.TryParse(Console.ReadLine(), out int resp);

            continuar = resp == 1;
        }
    }
}
