namespace Refatoracao;

public class Email
{
    public void Send(Order order)
    {
        Console.WriteLine($"Enviando e-mail para {order.CustomerEmail}...");
        Console.WriteLine($"order confirmado. Total: R$ {order.Total:F2}");
    }
}