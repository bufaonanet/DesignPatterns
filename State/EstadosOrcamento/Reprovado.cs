namespace State.EstadosOrcamento;

public class Reprovado : EstadoOrcamento
{    
    public void AplicaDescontoExtra(Orcamento orcamento)
    {
        throw new Exception("Orçamentos reprovados não recebem desconto extra!");

    }

    public void Aprova(Orcamento orcamento)
    {
        throw new Exception("O Orçamento já foi Reprovado!");
    }

    public void Finaliza(Orcamento orcamento)
    {
        throw new Exception("O Orçamento já foi Reprovado!");
    }

    public void Reprova(Orcamento orcamento)
    {
        throw new Exception("O Orçamento já foi Reprovado!");
    }
}
