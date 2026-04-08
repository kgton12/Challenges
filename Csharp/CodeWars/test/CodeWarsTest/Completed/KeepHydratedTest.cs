using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class KeepHydratedTest
{
    [Test]
    [Order(1)]
    public static void Test1()
    {
        Assert.That(KeepHydrated.Litres(2), Is.EqualTo(1));
    }

    [Test]
    [Order(2)]
    public static void Test2()
    {
        Assert.That(KeepHydrated.Litres(1.4), Is.Zero);
    }

    [Test]
    [Order(3)]
    public static void Test3()
    {
        Assert.That(KeepHydrated.Litres(12.3), Is.EqualTo(6));
    }

    [Test]
    [Order(4)]
    public static void Test4()
    {
        Assert.That(KeepHydrated.Litres(0.82), Is.Zero);
    }

    [Test]
    [Order(5)]
    public static void Test5()
    {
        Assert.That(KeepHydrated.Litres(11.8), Is.EqualTo(5));
    }

    [Test]
    [Order(6)]
    public static void Test6()
    {
        Assert.That(KeepHydrated.Litres(1787), Is.EqualTo(893));
    }
    [Test]
    [Order(7)]
    public static void Test7()
    {
        Assert.That(KeepHydrated.Litres(0), Is.Zero);
    }
}
