using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class WhatsAWhatsaPerfectPowerAnywayAnywayTest
{
    [Test, Order(1)]
    public void Test0()
    {
        Assert.That(WhatsaPerfectPowerAnyway.IsPerfectPower(0), Is.Null, "0 is not a perfect number");
    }

    [Test, Order(2)]
    public void Test1()
    {
        Assert.That(WhatsaPerfectPowerAnyway.IsPerfectPower(1), Is.Null, "1 is not a perfect number");
    }

    [Test, Order(3)]
    public void Test2()
    {
        Assert.That(WhatsaPerfectPowerAnyway.IsPerfectPower(2), Is.Null, "2 is not a perfect number");
    }

    [Test, Order(4)]
    public void Test3()
    {
        Assert.That(WhatsaPerfectPowerAnyway.IsPerfectPower(3), Is.Null, "3 is not a perfect number");
    }

    [Test, Order(5)]
    public void Test4()
    {
        Assert.That(WhatsaPerfectPowerAnyway.IsPerfectPower(4), Is.EqualTo((2, 2)), "4 = 2^2");
    }

    [Test, Order(6)]
    public void Test5()
    {
        Assert.That(WhatsaPerfectPowerAnyway.IsPerfectPower(5), Is.Null, "5 is not a perfect power");
    }

    [Test, Order(7)]
    public void Test8()
    {
        Assert.That(WhatsaPerfectPowerAnyway.IsPerfectPower(8), Is.EqualTo((2, 3)), "8 = 2^3");
    }

    [Test, Order(8)]
    public void Test9()
    {
        Assert.That(WhatsaPerfectPowerAnyway.IsPerfectPower(9), Is.EqualTo((3, 2)), "9 = 3^2");
    }

    [Test, Order(9)]
    public void TestUpTo500()
    {
        var pp = new int[] { 4, 8, 9, 16, 25, 27, 32, 36, 49, 64, 81, 100, 121, 125, 128, 144, 169, 196, 216, 225, 243, 256, 289, 324, 343, 361, 400, 441, 484 };
        foreach (var i in pp)
            Assert.That(WhatsaPerfectPowerAnyway.IsPerfectPower(i), Is.Not.Null, $"{i} is a perfect power");
    }
}
