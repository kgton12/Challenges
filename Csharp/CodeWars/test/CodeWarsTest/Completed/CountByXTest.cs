using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class CountByXTest
{
    [Test, Order(1)]
    public static void CountBy1()
    {
        Assert.That(CountByX.CountBy(1, 5), Is.EqualTo([1, 2, 3, 4, 5]), "Array does not match");
    }

    [Test, Order(2)]
    public static void CountBy2()
    {
        Assert.That(CountByX.CountBy(2, 5), Is.EqualTo([2, 4, 6, 8, 10]), "Array does not match");
    }
}
