namespace Strategy3.SemPattens;

public class PaymentProcessor
{
    public decimal ProcessPayment(decimal amount, CustomerType customerType)
    {
        if (customerType == CustomerType.Regular)
        {
            // Lógica de desconto para cliente regular
            decimal discount = amount * 0.1m;
            return amount - discount;
        }
        else if (customerType == CustomerType.Premium)
        {
            // Lógica de desconto para cliente premium
            decimal discount = amount * 0.2m;
            return amount - discount;
        }
        else if (customerType == CustomerType.VIP)
        {
            // Lógica de desconto para cliente VIP
            decimal discount = amount * 0.3m;
            return amount - discount;
        }
        // Mais ifs para outros tipos de clientes...

        return amount;
    }
}
