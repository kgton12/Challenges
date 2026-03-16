using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class CountTheDivisibleNumbersTest
{
    [Test]
    public void BasicTests()
    {
        Assert.That(CountTheDivisibleNumbers.DivisibleCount(6, 11, 2), Is.EqualTo(3));
    }

    [Test]
    public void LargeNumbers_SmallSpan()
    {
        long x = 1_000_000_000_000L;
        long y = 1_000_000_000_100L;
        long k = 7L;
        // Há 14 múltiplos de 7 entre x e y (inclusive)
        Assert.That(CountTheDivisibleNumbers.DivisibleCount(x, y, k), Is.EqualTo(14L));
    }

    [Test]
    public void VeryLargeK_AtUpperEdge()
    {
        long k = 1_000_000_000_000_000_000L;
        long x = 999_999_999_999_999_995L;
        long y = 1_000_000_000_000_000_000L;
        // Apenas y é divisível por k neste intervalo pequeno
        Assert.That(CountTheDivisibleNumbers.DivisibleCount(x, y, k), Is.EqualTo(1L));
    }

    [Test]
    public void NegativeRange()
    {
        // Múltiplos de 5 entre -10 e 10: -10, -5, 0, 5, 10 => 5
        Assert.That(CountTheDivisibleNumbers.DivisibleCount(-10L, 10L, 5L), Is.EqualTo(5L));
    }

    [Test]
    public void SingleLargeValue()
    {
        long v = 9_223_372_036_854_775_806L; // long.MaxValue - 1
        Assert.That(CountTheDivisibleNumbers.DivisibleCount(v, v, v), Is.EqualTo(1L));
    }
}
