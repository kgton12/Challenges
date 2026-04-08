using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class DescendingOrderClassTest
{
    [Test, Order(1)]
    public void Test0()
    {
        Assert.That(DescendingOrderClass.DescendingOrder(0), Is.Zero);
    }
}
