using BuilderApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace BuilderApi.Controllers;

[Route("[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
    private readonly ProductBuilder _productBuilder;

    public ProductsController(ProductBuilder productBuilder)
    {
        _productBuilder = productBuilder;
    }

    [HttpPost]
    public IActionResult CreateProduct(ProductDto productDto)
    {
        Product product = _productBuilder
            .WithId(productDto.Id)
            .WithName(productDto.Name)
            .WithDescription(productDto.Description)
            // outros métodos de construção...
            .Build();

        // Salvar o produto no banco de dados ou realizar outras operações

        return Ok(product);
    }
}
