using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class IsNDivisibleByTest
{
    [Test, Order(1)]
    public void BasicTest1()
    {
        Assert.That(IsNDivisibleBy.IsDivisible(3, 3, 4), Is.False);
    }

    [Test, Order(2)]
    public void BasicTest2()
    {
        Assert.That(IsNDivisibleBy.IsDivisible(12, 3, 4), Is.True);
    }
}
