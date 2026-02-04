using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class DeodorantEvaporatorTest
{
    [Test]
    public void Test1()
    {
        Assert.That(DeodorantEvaporator.Evaporator(10, 10, 10), Is.EqualTo(22));
    }
}
