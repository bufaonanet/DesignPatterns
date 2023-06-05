namespace Strategy3.ComPattern;

public class VIPCustomerDiscountStrategy : IDiscountStrategy
{
    public decimal ApplyDiscount(decimal amount)
    {
        decimal discount = amount * 0.3m;
        return amount - discount;
    }
}