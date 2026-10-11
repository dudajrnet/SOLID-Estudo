namespace Refatoracao;

public class RegularDiscount : DiscountCalculator
{
    public override decimal Discount { get; set; }

    public override void Calculate(decimal total) 
    {    
         Discount = total * 0.05m;
    }              
}