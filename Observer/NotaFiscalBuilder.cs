using Observer.Acoes;

namespace Observer;

public class NotaFiscalBuilder
{
    private string _razaoSocial;
    private string _cnpj;
    private double _valorTotal;
    private double _impostos;
    private IList<ItemDaNota> _todosItens = new List<ItemDaNota>();
    private DateTime _data;
    private string _observacoes;
    private IList<AcaoAposGerarNota> _acoesASeremExecutadas;

    public NotaFiscalBuilder()
    {
        _acoesASeremExecutadas = new List<AcaoAposGerarNota>();
    }

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
        var notaFiscal = new NotaFiscal(
            razaoSocial: _razaoSocial,
            cnpj: _cnpj,
            dataDeEmissao: _data,
            valorBruto: _valorTotal,
            impostos: _impostos,
            itens: _todosItens,
            observacoes: _observacoes);

        foreach (var acao in _acoesASeremExecutadas)
        {
            acao.Executa(notaFiscal);
        }

        return notaFiscal;
    }

    public void AdicionaAcao(AcaoAposGerarNota acaoAGerar)
    {
        _acoesASeremExecutadas.Add(acaoAGerar); 
    }
}