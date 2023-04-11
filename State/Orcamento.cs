using State.EstadosOrcamento;

namespace State;

public class Orcamento
{
    public EstadoOrcamento EstadoAtual { get; set; }
    public double Valor { get; set; }
    

    public Orcamento(double valor)
    {
        Valor = valor;       
        EstadoAtual = new EmAprovacao();
    }  

    public void AplicaDescontoExtra()
    {
        EstadoAtual.AplicaDescontoExtra(this);
    }

    public void Aprova()
    {
        EstadoAtual.Aprova(this);
    }

    public void Finaliza()
    {
        EstadoAtual.Finaliza(this);
    }

    public void Reprova()
    {
        EstadoAtual.Reprova(this);
    }
}