namespace Strategy;

// Classes ConcreteStrategy
public class ISS : IImposto
{
    public double Calcular(Orcamento orcamento)
    {
        double iss = orcamento.Valor * 0.06;
        return iss;
    }
}
