namespace Dip.Treinamento.Refatorcao;
public class SmsNotifier : INotifier
{
    public void Send(string message)
    {
        Console.WriteLine($"Sms enviado: {message}");
    }
}
