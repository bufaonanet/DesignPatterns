namespace Strategy;

// Classes ConcreteStrategy
public class ICMS : IImposto
{
    public double Calcular(Orcamento orcamento)
    {
        double icms = orcamento.Valor * 0.1;
        return icms;
    }
}
