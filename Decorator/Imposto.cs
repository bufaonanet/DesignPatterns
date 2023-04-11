namespace Decorator;


public abstract class Imposto
{
    protected Imposto OutroImposto { get; set; }

    protected Imposto(Imposto outroImposto)
    {
        OutroImposto = outroImposto;
    }
    public Imposto()
    {
    }

    public abstract double Calcula(Orcamento orcamento);

    protected double CalcularOutroImposto(Orcamento orcamento)
    {
        if (OutroImposto == null)
            return 0.0;

        return OutroImposto.Calcula(orcamento);
    }

}