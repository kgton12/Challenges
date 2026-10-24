using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class GrasshopperArrayMeanTest
{
    [Test]
    public void FirstTest()
    {
        Assert.That(GrasshopperArrayMean.FindAverage([1]), Is.EqualTo(1));
    }

    [Test]
    public void SecondTest()
    {
        Assert.That(GrasshopperArrayMean.FindAverage([1, 3, 5, 7]), Is.EqualTo(4));
    }

    [Test]
    public void ThirdTest()
    {
        Assert.That(GrasshopperArrayMean.FindAverage([-10, -5, -5, 0]), Is.EqualTo(-5));
    }

    [Test]
    public void FourthTest()
    {
        Assert.That(GrasshopperArrayMean.FindAverage([0]), Is.Zero);
    }
}
