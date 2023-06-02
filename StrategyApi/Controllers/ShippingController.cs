using Microsoft.AspNetCore.Mvc;
using StrategyApi.Models;
using StrategyApi.Services;

namespace StrategyApi.Controllers;

[Route("[controller]")]
[ApiController]
public class ShippingController : ControllerBase
{
    private readonly IDictionary<string, IShippingStrategy> shippingStrategies;

    public ShippingController()
    {
        shippingStrategies = new Dictionary<string, IShippingStrategy>
        {
            { "normal", new NormalShippingStrategy() },
            { "express", new ExpressShippingStrategy() },
            { "priority", new PriorityShippingStrategy() }
        };
    }

    [HttpPost]
    public IActionResult CalculateShippingPrice([FromBody] Shipping shipping)
    {
        if (!shippingStrategies.ContainsKey(shipping.shippingStrategy))
        {
            return BadRequest("Estratégia de frete inválida");
        }

        IShippingStrategy strategy = shippingStrategies[shipping.shippingStrategy];

        decimal shippingPrice = strategy.CalculateShippingPrice(shipping.productPrice);

        return Ok(new
        {
            frete = shippingPrice,
            strategia = strategy.GetType().Name
        });

    }
}
