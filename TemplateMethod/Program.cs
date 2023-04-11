using TemplateMethod;

Orcamento orcamento = new Orcamento(0);
orcamento.AdicionaItem(new Item("CANETA", 250.0));
orcamento.AdicionaItem(new Item("LAPIS", 250.0));
orcamento.AdicionaItem(new Item("Geladeira", 100));
orcamento.AdicionaItem(new Item("XBOX", 250.0));

IImposto impostoICPP = new ICPP();
IImposto impostoIKCV = new IKCV();

Console.WriteLine($"Imposto sobre {impostoICPP.GetType().Name} foi de {impostoICPP.Calcular(orcamento)}");
Console.WriteLine($"Imposto sobre {impostoIKCV.GetType().Name} foi de {impostoIKCV.Calcular(orcamento)}");

Console.ReadKey();