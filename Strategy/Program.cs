using Strategy;

IImposto iss = new ISS();
IImposto icms = new ICMS();

Orcamento orcamento = new(500.0);

CalculadorImposto calculador = new();

calculador.RealizaCalculo(orcamento, icms);
calculador.RealizaCalculo(orcamento, iss);

Console.ReadKey();