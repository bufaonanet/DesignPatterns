namespace State.EstadosOrcamento;

public class Aprovado : EstadoOrcamento
{
    public void AplicaDescontoExtra(Orcamento orcamento)
    {
        orcamento.Valor -= orcamento.Valor * 0.02;
    }

    public void Aprova(Orcamento orcamento)
    {
        // jah estou em aprovacao
        throw new Exception("Orçamento já está em estado de aprovação");
    }

    public void Finaliza(Orcamento orcamento)
    {
        // nao pode ser reprovado agora!
        throw new Exception("Orçamento está em estado de aprovação e não pode ser reprovado");
    }

    public void Reprova(Orcamento orcamento)
    {
        // daqui posso ir para o estado de finalizado
        orcamento.EstadoAtual = new Finalizado();
    }
}
