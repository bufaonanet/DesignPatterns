namespace Strategy3.ComPattern;

public class DefaultDiscountStrategy : IDiscountStrategy
{
    public decimal ApplyDiscount(decimal amount)
    {
        // Nenhuma lógica de desconto, retorna o valor original
        return amount;
    }
}