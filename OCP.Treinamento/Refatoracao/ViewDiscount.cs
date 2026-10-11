namespace Refatoracao;

public class ViewDiscount
{
    public void View(decimal total, decimal discount)
    {
        Console.WriteLine($"Desconto: R$ {discount:F2}");
        Console.WriteLine($"Total com desconto: R$ {total - discount:F2}");
    }
}