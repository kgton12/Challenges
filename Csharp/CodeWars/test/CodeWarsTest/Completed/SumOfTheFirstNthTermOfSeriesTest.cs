using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class SumOfTheFirstNthTermOfSeriesTest
{
    [Test]
    public void Test1()
    {
        Assert.That(SumOfTheFirstNthTermOfSeries.SeriesSum(0), Is.EqualTo("0.00"));
    }
    [Test]
    public void Test2()
    {
        Assert.That(SumOfTheFirstNthTermOfSeries.SeriesSum(9), Is.EqualTo("1,77"));
    }
}
