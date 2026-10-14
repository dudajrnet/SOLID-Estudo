namespace Violacao;

using System;

public interface IEquipamentoEscritorio
{
    void Imprimir(string documento);
    void Digitalizar(string documento);
    void EnviarFax(string documento);
    void FazerCopias(string documento, int quantidade);
}

public class ImpressoraSimples : IEquipamentoEscritorio
{
    public void Imprimir(string documento)
    {
        Console.WriteLine($"Imprimindo: {documento}");
    }

    public void Digitalizar(string documento)
    {
        throw new NotSupportedException("Esta impressora não digitaliza.");
    }

    public void EnviarFax(string documento)
    {
        throw new NotSupportedException("Esta impressora não envia fax.");
    }

    public void FazerCopias(string documento, int quantidade)
    {
        throw new NotSupportedException("Esta impressora não faz cópias.");
    }
}

public class Scanner : IEquipamentoEscritorio
{
    public void Imprimir(string documento)
    {
        throw new NotSupportedException("Este scanner não imprime.");
    }

    public void Digitalizar(string documento)
    {
        Console.WriteLine($"Digitalizando: {documento}");
    }

    public void EnviarFax(string documento)
    {
        throw new NotSupportedException("Este scanner não envia fax.");
    }

    public void FazerCopias(string documento, int quantidade)
    {
        throw new NotSupportedException("Este scanner não faz cópias.");
    }
}

public class AparelhoDeFax : IEquipamentoEscritorio
{
    public void Imprimir(string documento)
    {
        throw new NotSupportedException("Este aparelho de fax não imprime.");
    }

    public void Digitalizar(string documento)
    {
        throw new NotSupportedException("Este aparelho de fax não digitaliza.");
    }

    public void EnviarFax(string documento)
    {
        Console.WriteLine($"Enviando por fax: {documento}");
    }

    public void FazerCopias(string documento, int quantidade)
    {
        throw new NotSupportedException("Este aparelho de fax não faz cópias.");
    }
}

public class Multifuncional : IEquipamentoEscritorio
{
    public void Imprimir(string documento)
    {
        Console.WriteLine($"Multifuncional imprimindo: {documento}");
    }

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
}