namespace Refatoracao;

public class Impressao : IImpressao
{
    public void Imprimir(string documento)
    {
        Console.WriteLine($"Imprimindo: {documento}");
    }
}