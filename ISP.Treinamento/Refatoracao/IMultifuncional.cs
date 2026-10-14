namespace Refatoracao;

public interface IMultifuncional
{
    void Imprimir(string documento);
    void Digitalizar(string documento);
    void EnviarFax(string documento);
    void FazerCopias(string documento, int quantidade);
}