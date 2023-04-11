namespace Builder;

public class NotaFiscalBuilder
{
    private string _razaoSocial;
    private string _cnpj;
    private double _valorTotal;
    private double _impostos;
    private IList<ItemDaNota> _todosItens = new List<ItemDaNota>();
    private DateTime _data;
    private string _observacoes;

    public NotaFiscalBuilder ParaEmpresa(string razaoSocial)
    {
        _razaoSocial = razaoSocial;
        return this;
    }

    public NotaFiscalBuilder ComCnpj(string cnpj)
    {
        _cnpj = cnpj;
        return this;
    }

    public NotaFiscalBuilder NaDataAtual()
    {
        _data = DateTime.Now;
        return this;
    }

    public NotaFiscalBuilder ComObservacoes(string observacoes)
    {
        _observacoes = observacoes;
        return this;
    }

    public NotaFiscalBuilder ComItem(ItemDaNota item)
    {
        _todosItens.Add(item);
        _valorTotal += item.Valor;
        _impostos += item.Valor * 0.05;
        return this;
    }

    public NotaFiscal Constroi()
    {
        return new NotaFiscal(
            razaoSocial:_razaoSocial,
            cnpj:_cnpj,
            dataDeEmissao: _data,
            valorBruto: _valorTotal, 
            impostos: _impostos,
            itens: _todosItens,
            observacoes: _observacoes);


    }
}