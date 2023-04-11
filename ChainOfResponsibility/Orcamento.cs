namespace ChainOfResponsibility;

public class Orcamento
{
    public double Valor { get; private set; }
    public List<Item> Itens { get; private set; }

    public Orcamento(double valor)
    {
        Valor = valor;
        Itens = new();
    }

    public void AdicionaItem(Item item)
    {
        Valor += item.Valor;
        Itens.Add(item);
    }
}