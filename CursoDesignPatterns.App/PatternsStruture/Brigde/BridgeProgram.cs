using CursoDesignPatterns.App.PatternsStruture.Brigde.Abrastracao;
using CursoDesignPatterns.App.PatternsStruture.Brigde.Abrastracao.Interfaces;
using CursoDesignPatterns.App.PatternsStruture.Brigde.Implementacao;
using System.Runtime.CompilerServices;

namespace CursoDesignPatterns.App.PatternsStructure.Brigde;

public class BridgeProgram
{
    public IMaterial Material { get; set; }

    public void ConsultarCanetasPinceisNoEstoque()
    {
        Console.WriteLine(this.Material.ConsultarNoEstoque());
    }

    public void Executar()
    {

        while(true)
        {
            Random random = new();

            Material = random.Next(2) == 1 ? new CanetaEsferografica() : new PincelMarcador();

            Material.CorImplementacao = random.Next(1, 4) switch
            {
                1 => new Azul(),
                2 => new Preta(),
                3 => new Vermelha(),
                _ => throw new NotImplementedException()
            };

            ConsultarCanetasPinceisNoEstoque();

            Console.WriteLine($"Pressione <Enter> para continuar ou qualquer tecla para parar.");
            if (Console.ReadKey().KeyChar != 13) break;
        }
        
    }
}