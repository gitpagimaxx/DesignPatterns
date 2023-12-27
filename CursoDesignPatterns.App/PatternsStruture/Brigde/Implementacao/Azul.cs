using CursoDesignPatterns.App.PatternsStruture.Brigde.Implementacao.Interfaces;

namespace CursoDesignPatterns.App.PatternsStruture.Brigde.Implementacao;

public class Azul : ICor
{
    public string ConsultarQuantidadePorCor(string tipoAbstracao)
    {
        var quantidade = new Random().Next(100, 500);

        return $"Existem {quantidade} para {tipoAbstracao} de cor Azul no estoque";
    }
}
