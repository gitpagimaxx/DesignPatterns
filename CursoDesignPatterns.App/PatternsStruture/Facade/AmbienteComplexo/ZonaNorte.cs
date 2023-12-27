namespace CursoDesignPatterns.App.PatternsStruture.Facade.AmbienteComplexo
{
    public class ZonaNorte
    {
        public List<object> ExecutaRotinaVendasPerdidas(DateTime periodo)
        {
            Console.WriteLine("[!] Executando complexidade rotina de vendas perdidas região Norte. Periodo: " + periodo);

            return new List<object>();
        }
    }
}
