namespace Dip.Treinamento.Refatorcao;
public class EmailNotifier : INotifier
{
    public void Send(string message)
    {
        Console.WriteLine($"E-mail enviado: {message}");
    }
}