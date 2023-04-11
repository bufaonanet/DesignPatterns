namespace Builder2.classes;

// Definição da classe Builder
public class PizzaBuilder
{
    private Pizza pizza;

    public PizzaBuilder()
    {
        pizza = new Pizza();
    }

    public PizzaBuilder EscolherMassa(string tipo)
    {
        pizza.TipoMassa = tipo;
        return this;
    }

    public PizzaBuilder EscolherQueijo(string tipo)
    {
        pizza.TipoQueijo = tipo;
        return this;
    }

    public PizzaBuilder AdicionarIngrediente(string ingrediente)
    {
        if (pizza.Ingredientes == null)
        {
            pizza.Ingredientes = new List<string>();
        }
        pizza.Ingredientes.Add(ingrediente);
        return this;
    }

    public PizzaBuilder UsarFornoConvencional()
    {
        pizza.FornoConvencional = true;
        return this;
    }

    public PizzaBuilder UsarFornoALenha()
    {
        pizza.FornoConvencional = false;
        return this;
    }

    public Pizza CriarPizza()
    {
        return pizza;
    }
}

