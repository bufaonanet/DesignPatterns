using ChainOfResponsibility;

Orcamento orcamento = new Orcamento(0);
orcamento.AdicionaItem(new Item("CANETA", 250.0));
orcamento.AdicionaItem(new Item("LAPIS", 250.0));
orcamento.AdicionaItem(new Item("Geladeira", 100));
orcamento.AdicionaItem(new Item("XBOX", 250.0));

double desconto = CalculadorDeDescontos.Calcula(orcamento);

Console.WriteLine(desconto);
Console.ReadKey();