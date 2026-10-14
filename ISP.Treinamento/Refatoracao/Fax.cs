namespace Refatoracao;

public class Fax : IFax
{
    public void EnviarFax(string documento)
    {
        Console.WriteLine($"Enviando por fax: {documento}");
    }
}