namespace Dip.Treinamento.Violacao;

public class EmailNotifier
{
    public void Send(string message)
    {
        Console.WriteLine($"E-mail enviado: {message}");
    }
}

public class SmsNotifier
{
    public void Send(string message)
    {
        Console.WriteLine($"Sms enviado: {message}");
    }
}

public class OrderService
{
    private readonly EmailNotifier _notifier = new EmailNotifier();//se trocar para SmsNotifier altera a classe principal.

    public void PlaceOrder()
    {
        Console.WriteLine("Pedido realizado.");
        _notifier.Send("Seu pedido foi realizado.");
    }
}