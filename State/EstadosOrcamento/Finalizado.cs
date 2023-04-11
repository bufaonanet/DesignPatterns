namespace State.EstadosOrcamento;

public class Finalizado : EstadoOrcamento
{    
    public void AplicaDescontoExtra(Orcamento orcamento)
    {
        throw new Exception("Orçamentos finalizados não recebem desconto extra!");
    }

    public void Aprova(Orcamento orcamento)
    {
        throw new Exception("O Orçamento já foi Finalizado!");
    }

    public void Finaliza(Orcamento orcamento)
    {
        throw new Exception("O Orçamento já foi Finalizado!");
    }

    public void Reprova(Orcamento orcamento)
    {
        throw new Exception("O Orçamento já foi Finalizado!");
    }
}