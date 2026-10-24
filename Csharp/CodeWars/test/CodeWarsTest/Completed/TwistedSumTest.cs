using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class TwistedSumTest
{
    [Test]
    public void When03_Then6()
    {
        Assert.That(TwistedSum.Solution(3), Is.EqualTo(6));
    }

    [Test]
    public void When10_Then46()
    {
        Assert.That(TwistedSum.Solution(10), Is.EqualTo(46));
    }

    [Test]
    public void When11_Then48()
    {
        Assert.That(TwistedSum.Solution(11), Is.EqualTo(48));
    }

    [Test]
    public void When12_Then51()
    {
        Assert.That(TwistedSum.Solution(12), Is.EqualTo(51));
    }
}
