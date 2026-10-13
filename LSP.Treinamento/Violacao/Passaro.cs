namespace Violacao;

public abstract class Passaro
{
    public abstract void Comer();
    public abstract void Voar();
}

public class Pardal : Passaro
{
    public override void Comer()
    {
        Console.WriteLine("O pardal está comendo.");
    }

    public override void Voar()
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

    public override void Voar()
    {
        throw new Exception("Pinguim não voa");
    }
}

public class Acao
{
    public void FazerPassaroAgir(Passaro passaro)
    {
      passaro.Comer();
      passaro.Voar();  
    }
}