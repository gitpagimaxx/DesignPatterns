using CursoDesignPatterns.App.PatternsStruture.Brigde.Abrastracao.Interfaces;
using CursoDesignPatterns.App.PatternsStruture.Brigde.Implementacao.Interfaces;

namespace CursoDesignPatterns.App.PatternsStruture.Brigde.Abrastracao;

public class PincelMarcador : IMaterial
{
    public ICor CorImplementacao { get; set; }

    public string ConsultarNoEstoque()
    {
        return this.CorImplementacao.ConsultarQuantidadePorCor("Pincel Marcador");
    }
}
