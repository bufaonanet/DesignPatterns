namespace BuilderApi.Models;

// Product Builder
public class ProductBuilder
{
    private Product product;

    public ProductBuilder()
    {
        product = new Product();
    }

    public ProductBuilder WithId(int id)
    {
        product.Id = id;
        return this;
    }

    public ProductBuilder WithName(string name)
    {
        product.Name = name;
        return this;
    }

    public ProductBuilder WithDescription(string description)
    {
        product.Description = description;
        return this;
    }

    // outros métodos para construção...

    public Product Build()
    {
        return product;
    }
}