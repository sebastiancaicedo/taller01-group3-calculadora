using Xunit;
using ClaseCalculadora = Calculadora.CalcLib.Calculadora;

namespace Calculadora.xUnitTests;

public class UnitTestsCalculadora
{
    [Fact]
    public void TestSumaInt()
    {
        //arrange
        int a = 98;
        int b = 3;
        int expected = 101;

        //act
        ClaseCalculadora c = new();
        int actual = c.Suma(a,b).GetAwaiter().GetResult();

        //asset
        Assert.Equal(actual, expected);
    }

    [Fact]
    public void TestSumaIntNegativa()
    {
        //arrange
        int a = 5803;
        int b = -3;
        int expected = 5800;

        //act
        ClaseCalculadora c = new();
        int actual = c.Suma(a,b).GetAwaiter().GetResult();

        //asset
        Assert.Equal(actual, expected);
    }

    [Fact]
    public void TestSumaDecimal()
    {
        //arrange
        decimal a = 15.96M;
        decimal b = 5.21M;
        decimal expected = 21.17M;

        //act
        ClaseCalculadora c = new();
        decimal actual = c.Suma(a,b).GetAwaiter().GetResult();

        //asset
        Assert.Equal(actual, expected);
    }
}