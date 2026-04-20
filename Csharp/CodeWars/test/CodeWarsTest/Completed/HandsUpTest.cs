using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class HandsUpTest
{
    [Test, Order(1)]
    public void Test1()
    {
        Assert.That(HandsUp.GetPositions(5), Is.EqualTo([2, 1, 0]));
    }

    [Test, Order(2)]
    public void Test2()
    {
        Assert.That(HandsUp.GetPositions(33), Is.EqualTo([0, 2, 0]));
    }

    [Test, Order(3)]
    public void Test3()
    {
        Assert.That(HandsUp.GetPositions(0), Is.EqualTo([0, 0, 0]));
    }
}
