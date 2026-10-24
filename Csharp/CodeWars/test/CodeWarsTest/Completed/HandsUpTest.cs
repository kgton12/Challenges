using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class HandsUpTest
{
    [Test]
    public void Test1()
    {
        Assert.That(HandsUp.GetPositions(5), Is.EqualTo([2, 1, 0]));
    }

    [Test]
    public void Test2()
    {
        Assert.That(HandsUp.GetPositions(33), Is.EqualTo([0, 2, 0]));
    }

    [Test]
    public void Test3()
    {
        Assert.That(HandsUp.GetPositions(0), Is.EqualTo([0, 0, 0]));
    }
}
