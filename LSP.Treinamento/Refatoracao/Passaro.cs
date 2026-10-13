using System.Net.NetworkInformation;

namespace Refatoracao;

public abstract class Passaro
{
    public abstract void Comer();
}

public interface IPassaroVoador
{
    public void Voar();
}

public class Pardal : Passaro, IPassaroVoador
{
    public override void Comer()
    {
        Console.WriteLine("O pardal está comendo.");
    }

    public void Voar()
    {
        Console.WriteLine("O pardal está voando.");
    }
}

public class Pinguim: Passaro
{
    public override void Comer()
    {
        Console.WriteLine("O pinguim está comendo.");
    }
}

public class Acao
{
    public void FazerPassaroComer(Passaro passaro)
    {
      passaro.Comer();
    }

    public void FazerPassaroVoar(IPassaroVoador passaro)
    {
        passaro.Voar();
    }

    public void FazerPassarosAgir(Pinguim pinguim, Pardal pardal)
    {        
        pardal.Comer();

        pardal.Voar();

        pinguim.Comer();
    }

}

