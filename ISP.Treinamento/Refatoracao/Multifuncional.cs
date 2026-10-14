namespace Refatoracao;

public class Multifuncional : IMultifuncional
{
    public void Digitalizar(string documento)
    {
        Console.WriteLine($"Multifuncional digitalizando: {documento}");
    }

    public void EnviarFax(string documento)
    {
        Console.WriteLine($"Multifuncional enviando por fax: {documento}");
    }

    public void FazerCopias(string documento, int quantidade)
    {
        Console.WriteLine($"Fazendo {quantidade} cópia(s) de: {documento}");
    }

    public void Imprimir(string documento)
    {
       Console.WriteLine($"Multifuncional imprimindo: {documento}");
    }
}