using Builder;

NotaFiscal nf = new NotaFiscalBuilder()
    .ParaEmpresa("Caelum Ensino e Inovação")
    .ComCnpj("23.456.789/0001-12")
    .ComItem(new ItemDaNota("item 1", 100.0))
    .ComItem(new ItemDaNota("item 2", 200.0))
    .ComItem(new ItemDaNota("item 3", 200.0))
    .ComObservacoes("entregar nf pessoalmente")
    .NaDataAtual()
    .Constroi();

Console.WriteLine(nf);
Console.ReadKey();