using CursoDesignPatterns.App.PatternsStruture.Flyweight;
using System.Security.Cryptography.X509Certificates;

namespace CursoDesignPatterns.App.PatternsStructure.Adapter;

public class FlyweihtProgram
{
    public static void Executar()
    {
        List<string> coresTamanhos = new List<string>()
    {
        "azul:pequena",
        "cinza:media",
        "vermelha:grande",
        "azul:pequena",
        "cinza:media",
        "vermelha:grande",
        "azul:pequena",
        "cinza:media",
        "vermelha:grande",
    };

        FlyweightFactory factory = new FlyweightFactory();

        foreach (var item in coresTamanhos)
        {
            var cor = item.Split(":")[0];
            var tamanho = item.Split(":")[1];
            var espacoNave = factory.GetEspacoNave(cor);
            espacoNave.Exibir(cor, tamanho);
        }
    }
}