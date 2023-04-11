namespace Strategy;

// Classe Context
public class CalculadorImposto
{
    public void RealizaCalculo(Orcamento orcamento, IImposto imposto)
    {
        var aliquota = imposto.Calcular(orcamento);

        Console.WriteLine($"Alíquota calculada para {imposto.GetType().Name} foi de {aliquota}");
    }
}