namespace Observer.Acoes;

public class EnviadorDeEmail : AcaoAposGerarNota
{
    public void Executa(NotaFiscal notaFiscal)
    {
        Console.WriteLine("enviando por e-mail");
    }
}