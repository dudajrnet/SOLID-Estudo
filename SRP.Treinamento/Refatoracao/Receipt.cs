using System.Text;

namespace Refatoracao;

public class Receipt
{
    public void ProvideReceipt(Order order)
    {
        var receipt = new StringBuilder();
        
        receipt.AppendLine("=== RECIBO ===");
        receipt.AppendLine($"Cliente: {order.CustomerEmail}");
        receipt.AppendLine($"Subtotal: R$ {order.Subtotal:F2}");
        receipt.AppendLine($"Desconto: R$ {order.Discount:F2}");
        receipt.AppendLine($"Total: R$ {order.Total:F2}");

        File.WriteAllText("receipt.txt", receipt.ToString());
    }
}