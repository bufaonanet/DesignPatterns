namespace State.EstadosOrcamento;


public class EmAprovacao : EstadoOrcamento
{
    public void AplicaDescontoExtra(Orcamento orcamento)
    {
        orcamento.Valor -= orcamento.Valor * 0.05;
    }

    public void Aprova(Orcamento orcamento)
    {
        // desse estado posso ir para o estado de aprovado
        orcamento.EstadoAtual = new Aprovado();
    }

    public void Finaliza(Orcamento orcamento)
    {
        // daqui não posso ir direto para finalizado
        throw new Exception("Orcamento em aprovação não podem ir para finalizado diretamente");
    }

    public void Reprova(Orcamento orcamento)
    {
        // desse estado posso ir para o estado de reprovado tambem
        orcamento.EstadoAtual = new Reprovado();
    }
}