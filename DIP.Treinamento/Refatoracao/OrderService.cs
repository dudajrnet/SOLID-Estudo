namespace Dip.Treinamento.Refatorcao;
public class OrderService
{
    private readonly INotifier _notifier;

    public OrderService(INotifier notifier)
    {
        _notifier = notifier;
    }

    public void PlaceOrder()
    {
        Console.WriteLine("Pedido realizado.");
        _notifier.Send("Seu pedido foi realizado.");
    }
}