namespace Observer.Acoes;

public class Impressora : AcaoAposGerarNota
{
    public void Executa(NotaFiscal notaFiscal)
    {
        Console.WriteLine("imprimindo notaFiscal");
    }

}