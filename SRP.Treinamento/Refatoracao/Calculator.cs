namespace Refatoracao;

public class Calculator
{
    public void Calculate(Order order)
    {
        order.Total = order.Subtotal - order.Discount;
    }
}
