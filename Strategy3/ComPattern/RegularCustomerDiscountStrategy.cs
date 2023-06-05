namespace Strategy3.ComPattern;

public class RegularCustomerDiscountStrategy : IDiscountStrategy
{
    public decimal ApplyDiscount(decimal amount)
    {
        decimal discount = amount * 0.1m;
        return amount - discount;
    }
}

