using State;

Orcamento reforma = new Orcamento(500.0);


reforma.AplicaDescontoExtra();
Console.WriteLine(reforma.Valor); // imprime 475,00 pois descontou 5%
reforma.Aprova(); // aprova nota!

reforma.AplicaDescontoExtra();
Console.WriteLine(reforma.Valor); // imprime 465,50 pois descontou 2%

reforma.Finaliza();

// reforma.AplicaDescontoExtra(); lancaria excecao, pois não pode dar desconto nesse estado
// reforma.Aprova(); lança exceção, pois não pode ir para aprovado