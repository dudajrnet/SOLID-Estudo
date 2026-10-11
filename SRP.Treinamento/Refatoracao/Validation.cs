namespace Refatoracao;

public class Validation
{
    public void Validate(Order order)
    {
      // Validação
        if (string.IsNullOrWhiteSpace(order.CustomerEmail))
            throw new ArgumentException("O e-mail do cliente é obrigatório.");

        if (order.Subtotal < 0 || order.Discount < 0)
            throw new ArgumentException("Os valores não podem ser negativos.");

        if (order.Discount > order.Subtotal)
            throw new ArgumentException("O desconto não pode superar o subtotal.");  
    }
}