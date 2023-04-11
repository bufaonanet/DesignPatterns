namespace TemplateMethod;

class IKCV : TemplateDeImpostoCondicional
{
    protected override double MaximaTaxacao(Orcamento orcamento)
    {
        return orcamento.Valor * 0.10;
    }

    protected override double MinimaTaxacao(Orcamento orcamento)
    {
        return orcamento.Valor * 0.06;
    }

    protected override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
    {
        if (orcamento.Valor > 500 && TemItemMaiorQue100ReaisNo(orcamento))
            return true;

        return false;
    }

    private bool TemItemMaiorQue100ReaisNo(Orcamento orcamento)
    {
        foreach (Item item in orcamento.Itens)
        {
            if (item.Valor > 100) return true;
        }
        return false;
    }
}