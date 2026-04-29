using Clase1.Logica.Juego;
using Clase1.Logica.Providers;

namespace Clase1.Tests;

public class JuegoAdivinarTest
{
    [Fact]
    public void DadoQueElNumeroEs100YPongo0DaCongelado()
    {
        var pista = new Pista();
        string resultado = pista.ObtenerPista(100, 0);
        Assert.Equal("congelado", resultado);
    }

    [Fact]
    public void DadoQueElNumeroEs100YPongo97DaCaliente()
    {
        var pista = new Pista();
        string resultado = pista.ObtenerPista(100, 97);
        Assert.Equal("caliente", resultado);
    }

    [Fact]
    public void DadoQueElNumeroEs100YPongo90DaTibio()
    {
        var pista = new Pista();
        string resultado = pista.ObtenerPista(100, 90);
        Assert.Equal("tibio", resultado);
    }

    [Fact]
    public void DadoQueElNumeroEs100YPongo60DaFrio()
    {
        var pista = new Pista();
        string resultado = pista.ObtenerPista(100, 60);
        Assert.Equal("frio", resultado);
    }
}
