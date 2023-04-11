namespace State.EstadosOrcamento;

public interface EstadoOrcamento
{
    void AplicaDescontoExtra(Orcamento orcamento);
    void Aprova(Orcamento orcamento);
    void Reprova(Orcamento orcamento);
    void Finaliza(Orcamento orcamento);
}
