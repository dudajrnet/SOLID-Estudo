using Refatoracao;

namespace LSP.Treinamento.Tests;

public class PassarosTests
{
    [Fact]
    public void Pardal_Comer_DeveExibirMensagemDeAlimentacao()
    {
        var pardal = new Pardal();

        var saida = CapturarSaida(pardal.Comer);

        Assert.Equal($"O pardal está comendo.{Environment.NewLine}", saida);
    }

    [Fact]
    public void Pardal_Voar_DeveExibirMensagemDeVoo()
    {
        var pardal = new Pardal();

        var saida = CapturarSaida(pardal.Voar);

        Assert.Equal($"O pardal está voando.{Environment.NewLine}", saida);
    }

    [Fact]
    public void Pinguim_Comer_DeveExibirMensagemDeAlimentacao()
    {
        var pinguim = new Pinguim();

        var saida = CapturarSaida(pinguim.Comer);

        Assert.Equal($"O pinguim está comendo.{Environment.NewLine}", saida);
    }

    [Fact]
    public void Acao_FazerPassaroComer_DeveAceitarPardal()
    {
        var acao = new Acao();
        Passaro pardal = new Pardal();

        var saida = CapturarSaida(() => acao.FazerPassaroComer(pardal));

        Assert.Equal($"O pardal está comendo.{Environment.NewLine}", saida);
    }

    [Fact]
    public void Acao_FazerPassaroComer_DeveAceitarPinguim()
    {
        var acao = new Acao();
        Passaro pinguim = new Pinguim();

        var saida = CapturarSaida(() => acao.FazerPassaroComer(pinguim));

        Assert.Equal($"O pinguim está comendo.{Environment.NewLine}", saida);
    }

    [Fact]
    public void Acao_FazerPassaroVoar_DeveAceitarPardal()
    {
        var acao = new Acao();
        IPassaroVoador pardal = new Pardal();

        var saida = CapturarSaida(() => acao.FazerPassaroVoar(pardal));

        Assert.Equal($"O pardal está voando.{Environment.NewLine}", saida);
    }

    [Fact]
    public void Acao_FazerPassarosAgir_DeveExecutarAcoesDoPardalEPinguim()
    {
        var acao = new Acao();

        var saida = CapturarSaida(() =>
            acao.FazerPassarosAgir(new Pinguim(), new Pardal()));

        Assert.Equal(
            $"O pardal está comendo.{Environment.NewLine}" +
            $"O pardal está voando.{Environment.NewLine}" +
            $"O pinguim está comendo.{Environment.NewLine}",
            saida);
    }

    [Fact]
    public void Pardal_DeveSerPassaroEVoador()
    {
        var pardal = new Pardal();

        Assert.IsAssignableFrom<Passaro>(pardal);
        Assert.IsAssignableFrom<IPassaroVoador>(pardal);
    }

    [Fact]
    public void Pinguim_DeveSerPassaroMasNaoVoador()
    {
        var pinguim = new Pinguim();

        Assert.IsAssignableFrom<Passaro>(pinguim);
        Assert.False(pinguim is IPassaroVoador);
    }

    private static string CapturarSaida(System.Action executar)
    {
        using var writer = new StringWriter();
        var saidaOriginal = Console.Out;

        try
        {
            Console.SetOut(writer);
            executar();
            return writer.ToString();
        }
        finally
        {
            Console.SetOut(saidaOriginal);
        }
    }
}
