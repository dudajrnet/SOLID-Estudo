using System.Text;

public class OrderProcessor
{
    public void Process(Order order)
    {
        // Validação
        if (string.IsNullOrWhiteSpace(order.CustomerEmail))
            throw new ArgumentException("O e-mail do cliente é obrigatório.");

        if (order.Subtotal < 0 || order.Discount < 0)
            throw new ArgumentException("Os valores não podem ser negativos.");

        if (order.Discount > order.Subtotal)
            throw new ArgumentException("O desconto não pode superar o subtotal.");

        // Cálculo
        decimal total = order.Subtotal - order.Discount;

        // Persistência
        string orderData = $"{order.CustomerEmail};{total}{Environment.NewLine}";
        File.AppendAllText("orders.txt", orderData);

        // Envio de confirmação (simulado)
        Console.WriteLine($"Enviando e-mail para {order.CustomerEmail}...");
        Console.WriteLine($"order confirmado. Total: R$ {total:F2}");

        // Geração do recibo
        var receipt = new StringBuilder();
        receipt.AppendLine("=== RECIBO ===");
        receipt.AppendLine($"Cliente: {order.CustomerEmail}");
        receipt.AppendLine($"Subtotal: R$ {order.Subtotal:F2}");
        receipt.AppendLine($"Desconto: R$ {order.Discount:F2}");
        receipt.AppendLine($"Total: R$ {total:F2}");

        File.WriteAllText("receipt.txt", receipt.ToString());
    }
}