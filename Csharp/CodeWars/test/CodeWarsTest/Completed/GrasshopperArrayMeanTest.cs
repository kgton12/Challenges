using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class GrasshopperArrayMeanTest
{
    [Test, Order(1)]
    public void FirstTest()
    {
        Assert.That(GrasshopperArrayMean.FindAverage(new[] { 1 }), Is.EqualTo(1));
    }

    [Test, Order(2)]
    public void SecondTest()
    {
        Assert.That(GrasshopperArrayMean.FindAverage(new[] { 1, 3, 5, 7 }), Is.EqualTo(4));
    }

    [Test, Order(3)]
    public void ThirdTest()
    {
        Assert.That(GrasshopperArrayMean.FindAverage(new[] { -10, -5, -5, 0 }), Is.EqualTo(-5));
    }

    [Test, Order(4)]
    public void FourthTest()
    {
        Assert.That(GrasshopperArrayMean.FindAverage(new[] { 0 }), Is.Zero);
    }
}
