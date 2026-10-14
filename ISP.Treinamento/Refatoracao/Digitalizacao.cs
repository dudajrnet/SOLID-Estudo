namespace Refatoracao;

public class Digitalizacao : IDigitalizacao
{
    public void Digitalizar(string documento)
    {
        Console.WriteLine($"Digitalizando: {documento}");
    }    
}