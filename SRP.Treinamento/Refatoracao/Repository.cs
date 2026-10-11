namespace Refatoracao;

public class Repository
{
    public void Save(Order order)
    {
      string orderData = $"{order.CustomerEmail};{order.Total}{Environment.NewLine}";
      File.AppendAllText("orders.txt", orderData);
    }
}