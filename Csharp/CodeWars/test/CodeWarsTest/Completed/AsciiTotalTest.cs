using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class AsciiTotalTest
{
    [Test, Description("An empty string should return zero")]
    
    public void ZeroTest()
    {
        Assert.That(ASCIITotal.UniTotal(""), Is.Zero);
    }

    [Test, Description("Should work with single letters")]
    
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
    
    public void MultipleTest()
    {
        Assert.That(ASCIITotal.UniTotal("aaa"), Is.EqualTo(291));
    }

    [Test, Description("Should work with sentence and spaces")]
    
    public void SentenceTest()
    {
        Assert.That(ASCIITotal.UniTotal("Mary Had A Little Lamb"), Is.EqualTo(1873));
    }
}
