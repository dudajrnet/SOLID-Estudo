using System.Dynamic;

namespace Refatoracao;

public abstract class DiscountCalculator
{
     public abstract void Calculate(decimal total);
     public abstract decimal Discount{get; set;}
}