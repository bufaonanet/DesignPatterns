using Strategy3;
using Strategy3.ComPattern;

decimal amount = 100;
CustomerType customerType = CustomerType.Premium;

//var resultado = SemPattern(amount, customerType);

var resultado =  ComPattern(amount, customerType);

Console.WriteLine($"Total amount after payment processing: {resultado}");


Console.ReadKey();

static decimal SemPattern(decimal amount, CustomerType customerType)
{
    var paymentProcessor = new Strategy3.SemPattens.PaymentProcessor();
    return paymentProcessor.ProcessPayment(amount, customerType);
}

static decimal ComPattern(decimal amount, CustomerType customerType)
{
    IDiscountStrategy discountStrategy;

    switch (customerType)
    {
        case CustomerType.Regular:
            discountStrategy = new RegularCustomerDiscountStrategy();
            break;
        case CustomerType.Premium:
            discountStrategy = new PremiumCustomerDiscountStrategy();
            break;
        case CustomerType.VIP:
            discountStrategy = new VIPCustomerDiscountStrategy();
            break;
        default:
            discountStrategy = new DefaultDiscountStrategy();
            break;
    }

    var paymentProcessor = new Strategy3.ComPattern.PaymentProcessor(discountStrategy);
    return paymentProcessor.ProcessPayment(amount);
}