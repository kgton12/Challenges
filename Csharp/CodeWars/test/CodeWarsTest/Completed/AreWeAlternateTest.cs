using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class AreWeAlternateTest
{
    [Test]
    public void BasicTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(AreWeAlternate.IsAlt("amazon"), Is.True);
            Assert.That(AreWeAlternate.IsAlt("apple"), Is.False);
            Assert.That(AreWeAlternate.IsAlt("banana"), Is.True);
            Assert.That(AreWeAlternate.IsAlt("abecuc"), Is.True);
            Assert.That(AreWeAlternate.IsAlt("abeu"), Is.False);
        }
    }
}
