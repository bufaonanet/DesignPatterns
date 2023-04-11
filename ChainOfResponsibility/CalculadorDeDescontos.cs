namespace ChainOfResponsibility;

public class CalculadorDeDescontos
{
    public static double Calcula(Orcamento orcamento)
    {
        IDesconto d1 = new DescontoPorCincoItens();
        IDesconto d2 = new DescontoPorMaisDeQuinhentosReais();
        IDesconto d3 = new SemDesconto();

        d1.ProximoDesconto = d2;
        d2.ProximoDesconto = d3;

        return d1.Desconta(orcamento);
    }
}
