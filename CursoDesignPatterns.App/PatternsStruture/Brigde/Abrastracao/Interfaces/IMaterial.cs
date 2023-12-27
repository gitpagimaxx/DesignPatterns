using CursoDesignPatterns.App.PatternsStruture.Brigde.Implementacao.Interfaces;

namespace CursoDesignPatterns.App.PatternsStruture.Brigde.Abrastracao.Interfaces;

public interface IMaterial
{
    public ICor CorImplementacao { get; set; }

    string ConsultarNoEstoque();
}
