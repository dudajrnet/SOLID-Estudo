namespace Refatoracao;

public class DiscountProcessor(
    IEnumerable<DiscountCalculator> discountCalculators,
    ViewDiscount viewDiscount)
{
    public void Process(decimal total)
    {
        foreach (var discountCalculator in discountCalculators)
        {
            discountCalculator.Calculate(total);
            viewDiscount.View(total, discountCalculator.Discount);
        }
    }
}
