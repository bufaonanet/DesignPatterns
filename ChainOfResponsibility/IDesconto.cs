namespace ChainOfResponsibility;

public interface IDesconto
{
    IDesconto ProximoDesconto { get; set; }
    double Desconta(Orcamento orcamento);
}
