using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class UsdCnyTest
{
    [Test, Order(1)]
    public void BasicTest1()
    {
        Assert.That(UsdCny.Usdcny(15), Is.EqualTo("101,25 Chinese Yuan"), "Testing Usd value at: " + 15
            + "\n Should return: 101,25 Chinese Yuan");
    }

    [Test, Order(2)]
    public void BasicTest2()
    {
        Assert.That(UsdCny.Usdcny(465), Is.EqualTo("3138,75 Chinese Yuan"), "Testing Usd value at: " + 465
            + "\n Should return: 3138,75 Chinese Yuan");
    }
}
