namespace StrategyApi.Services;


/// <summary>
/// Enum com as opções de estratégia de cálculo de frete
/// </summary>
public enum ShippingStrategyType
{
    Normal,
    Express,
    Priority
}

/// <summary>
/// Strategy: Interface comum para as estratégias de cálculo de frete
/// </summary>
public interface IShippingStrategy
{
    decimal CalculateShippingPrice(decimal productPrice);
}

// ConcreteStrategy: Implementação da estratégia de cálculo de frete normal
public class NormalShippingStrategy : IShippingStrategy
{
    public decimal CalculateShippingPrice(decimal productPrice)
    {
        // Lógica de cálculo para frete normal
        return productPrice * 0.1m;
    }
}

// ConcreteStrategy: Implementação da estratégia de cálculo de frete expresso
public class ExpressShippingStrategy : IShippingStrategy
{
    public decimal CalculateShippingPrice(decimal productPrice)
    {
        // Lógica de cálculo para frete expresso
        return productPrice * 0.2m;
    }
}

// ConcreteStrategy: Implementação da estratégia de cálculo de frete prioritário
public class PriorityShippingStrategy : IShippingStrategy
{
    public decimal CalculateShippingPrice(decimal productPrice)
    {
        // Lógica de cálculo para frete prioritário
        return productPrice * 0.3m;
    }
}


