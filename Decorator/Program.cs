
using Decorator;

Imposto iss = new ISS(new ICMS());

Orcamento orcamento = new(500.0);

double valor = iss.Calcula(orcamento);

Console.WriteLine(valor);

Console.ReadKey();