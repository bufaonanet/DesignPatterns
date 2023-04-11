namespace Observer.Acoes;

public class NotaFiscalDao : AcaoAposGerarNota
{
    public void Executa(NotaFiscal notaFiscal)
    {
        Console.WriteLine("salvando no banco");
    }
}
