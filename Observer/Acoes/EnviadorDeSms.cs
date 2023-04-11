namespace Observer.Acoes;

public class EnviadorDeSms : AcaoAposGerarNota
{
    public void Executa(NotaFiscal notaFiscal)
    {
        Console.WriteLine("enviando por sms");
    }
}