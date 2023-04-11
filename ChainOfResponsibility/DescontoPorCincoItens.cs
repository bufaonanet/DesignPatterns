namespace ChainOfResponsibility;

public class DescontoPorCincoItens : IDesconto
{
    public IDesconto ProximoDesconto { get; set; }

    public double Desconta(Orcamento orcamento)
    {
        if (orcamento.Itens.Count > 5)
        {
            return orcamento.Valor * 0.1;
        }
        else
        {
            return ProximoDesconto.Desconta(orcamento);
        }
    }
}