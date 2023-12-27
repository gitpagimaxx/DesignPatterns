namespace DesignPatterns.App.PatternBehavior.Command.Receivers;

public class LuzLuminariaReceiver
{
    private bool _estaLigada = false;
    private int _intensidade = 100;

    public string ObterEstadoLuminaria() => _estaLigada ? "Ligada" : "Desligada";

    public void LigarLuz()
    { 
        if (_estaLigada)
            Console.WriteLine("A luz já está ligada");
        else
        {
            _estaLigada = !_estaLigada; 
            Console.WriteLine($"A luz foi {ObterEstadoLuminaria()}");
        }
    }

    public void DesligarLuz()
    {
        if (!_estaLigada)
        {
            Console.WriteLine("A luz já está desligada");
        }
        else
        {
            _estaLigada = !_estaLigada; 
            Console.WriteLine($"A luz foi {ObterEstadoLuminaria()}");
        }
    }

    public void AumentarIntensidade()
    {
        if (_intensidade >= 0 && _intensidade < 100) 
        {
            _intensidade += 20;
            Console.WriteLine($"Intensidade foi aumentada em {_intensidade}%");
        }
        else
        {
            Console.WriteLine($"Intensidade está em {_intensidade}%");
        }
    }

    public void DiminuirIntensidade()
    {
        if (_intensidade > 0 && _intensidade <= 100)
        {
            _intensidade -= 20;
            Console.WriteLine($"Intensidade foi diminuída para {_intensidade}%");
        }
        else
        {
            Console.WriteLine($"Intensidade está em {_intensidade}%");
        }
    }
}
