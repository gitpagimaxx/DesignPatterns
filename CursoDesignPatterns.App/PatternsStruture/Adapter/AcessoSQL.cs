namespace CursoDesignPatterns.App.PatternsStruture.Adapter;

internal class AcessoSQL
{
    public static string GetDadosPagar(string mes)
    {
        Dictionary<string, string> dic = new()
        {
            { "junho", "JUNHO\nCNPJ:123\nRazaoSocial: PAGIMAX\nValor: 1200.00" },
            { "julho", "JULHO\nCNPJ:123\nRazaoSocial: PAGIMAX\nValor: 1200.00" },
            { "agosto", "AGOSTO\nCNPJ:123\nRazaoSocial: PAGIMAX\nValor: 1200.00" },
            { "setembro", "SETEMBRO\nCNPJ:123\nRazaoSocial: PAGIMAX\nValor: 1200.00" },
            { "outubro", "OUTUBRO\nCNPJ:123\nRazaoSocial: PAGIMAX\nValor: 1200.00" }
        };

        return dic[mes];
    }

    public static string GetDadosReceber(string mes)
    {
        Dictionary<string, string> dic = new()
        {
            { "junho", "JUNHO\nCNPJ:123\nRazaoSocial: PAGIMAX\nValor: 1200.00" },
            { "julho", "JULHO\nCNPJ:123\nRazaoSocial: PAGIMAX\nValor: 1200.00" },
            { "agosto", "AGOSTO\nCNPJ:123\nRazaoSocial: PAGIMAX\nValor: 1200.00" },
            { "setembro", "SETEMBRO\nCNPJ:123\nRazaoSocial: PAGIMAX\nValor: 1200.00" },
            { "outubro", "OUTUBRO\nCNPJ:123\nRazaoSocial: PAGIMAX\nValor: 1200.00" }
        };

        return dic[mes];
    }
}
