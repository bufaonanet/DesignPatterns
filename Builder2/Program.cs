using Builder2.classes;

PizzaBuilder builder = new PizzaBuilder();

Pizza pizza = builder
    .EscolherMassa("fina")
    .EscolherQueijo("muçarela")
    .AdicionarIngrediente("tomate")
    .AdicionarIngrediente("cebola")
    .AdicionarIngrediente("azeitona")
    .UsarFornoConvencional()
    .CriarPizza();

// Saída: Pizza com massa fina, queijo muçarela, ingredientes: tomate, cebola, azeitona, cozida em forno convencional
pizza.MostrarPizza(); 