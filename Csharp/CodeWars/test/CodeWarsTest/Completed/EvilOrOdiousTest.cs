using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class EvilOrOdiousTest
{
    [Test]
    public void SampleTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(EvilOrOdious.Evil(1), Is.EqualTo("It's Odious!"));
            Assert.That(EvilOrOdious.Evil(2), Is.EqualTo("It's Odious!"));
            Assert.That(EvilOrOdious.Evil(3), Is.EqualTo("It's Evil!"));
        }
    }
}
