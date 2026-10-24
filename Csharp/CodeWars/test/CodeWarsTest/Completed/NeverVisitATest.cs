using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class NeverVisitATest
{
    [Test]
    public void Test1()
    {
        Assert.That(NeverVisitA.SubtractSum(11), Is.EqualTo("apple").IgnoreCase);
    }
}
