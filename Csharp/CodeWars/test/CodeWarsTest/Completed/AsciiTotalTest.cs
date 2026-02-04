using CodeWars.Resolutions;

namespace CodeWarsTest;

public class AsciiTotalTest
{
    [Test, Description("An empty string should return zero")]
    [Order(1)]
    public void ZeroTest()
    {
        Assert.That(ASCIITotal.UniTotal(""), Is.Zero);
    }

    [Test, Description("Should work with single letters")]
    [Order(2)]
    public void SingleTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(ASCIITotal.UniTotal("a"), Is.EqualTo(97));
            Assert.That(ASCIITotal.UniTotal("b"), Is.EqualTo(98));
            Assert.That(ASCIITotal.UniTotal("c"), Is.EqualTo(99));
            Assert.That(ASCIITotal.UniTotal("d"), Is.EqualTo(100));
            Assert.That(ASCIITotal.UniTotal("e"), Is.EqualTo(101));
        }
    }

    [Test, Description("Should work with multiple letters")]
    [Order(3)]
    public void MultipleTest()
    {
        Assert.That(ASCIITotal.UniTotal("aaa"), Is.EqualTo(291));
    }

    [Test, Description("Should work with sentence and spaces")]
    [Order(4)]
    public void SentenceTest()
    {
        Assert.That(ASCIITotal.UniTotal("Mary Had A Little Lamb"), Is.EqualTo(1873));
    }
}
