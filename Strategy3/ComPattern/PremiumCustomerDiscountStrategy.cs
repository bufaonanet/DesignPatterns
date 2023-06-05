namespace Strategy3.ComPattern;

public class PremiumCustomerDiscountStrategy : IDiscountStrategy
{
    public decimal ApplyDiscount(decimal amount)
    {
        decimal discount = amount * 0.2m;
        return amount - discount;
    }
}

