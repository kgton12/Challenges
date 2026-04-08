using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class MeanVsMedianClassTest
{
    [Test, Order(1)]
    public void Test1() =>
        Assert.That(MeanVsMedianClass.MeanVsMedian([1, 1, 1]), Is.EqualTo("same"));

    [Test, Order(2)]
    public void Test2() =>
        Assert.That(MeanVsMedianClass.MeanVsMedian([1, 2, 37]), Is.EqualTo("mean"));

    [Test, Order(3)]
    public void Test3() =>
        Assert.That(MeanVsMedianClass.MeanVsMedian([7, 14, -70]), Is.EqualTo("median"));

    [Test, Order(4)]
    public void Test4() =>
    Assert.That(MeanVsMedianClass.MeanVsMedian([-10, 20, 5]), Is.EqualTo("same"));
}