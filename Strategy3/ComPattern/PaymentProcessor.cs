namespace Strategy3.ComPattern;

public class PaymentProcessor
{
    private readonly IDiscountStrategy _discountStrategy;

    public PaymentProcessor(IDiscountStrategy discountStrategy)
    {
        _discountStrategy = discountStrategy;
    }

    public decimal ProcessPayment(decimal amount)
    {
        return _discountStrategy.ApplyDiscount(amount);
    }
}

