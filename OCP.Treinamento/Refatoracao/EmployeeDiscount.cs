namespace Refatoracao;

public class EmployeeDiscount : DiscountCalculator
{
    public override decimal Discount { get; set; }

    public override void Calculate(decimal total)
    {
         Discount = total * 0.20m;    
    }
}