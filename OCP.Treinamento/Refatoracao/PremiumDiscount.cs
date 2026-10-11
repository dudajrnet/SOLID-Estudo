namespace Refatoracao;

public class PremiumDiscount : DiscountCalculator
{
    public override decimal Discount { get; set; }

    public override void Calculate(decimal total)
    {
        Discount = total * 0.10m;
    }    
}