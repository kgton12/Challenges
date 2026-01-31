using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class SumOfTheFirstNthTermOfSeriesTest
{
    [Test]
    [Order(1)]
    public void Test1()
    {
        Assert.That(SumOfTheFirstNthTermOfSeries.SeriesSum(0), Is.EqualTo("0.00"));
    }
    [Test]
    [Order(2)]
    public void Test2()
    {
        Assert.That(SumOfTheFirstNthTermOfSeries.SeriesSum(9), Is.EqualTo("1.77"));
    }
}
