using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class WhichStringIsWorthMoreTest
{
    [Test]
    public void BasicTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(WhichStringIsWorthMore.HighestValue("AaBbCcXxYyZz0189", "KkLlMmNnOoPp4567"), Is.EqualTo("KkLlMmNnOoPp4567"));
            Assert.That(WhichStringIsWorthMore.HighestValue("ABcd", "0123"), Is.EqualTo("ABcd"));
            Assert.That(WhichStringIsWorthMore.HighestValue("!\"?$%^&*()", "{}[]@~'#:;"), Is.EqualTo("{}[]@~'#:;"));
            Assert.That(WhichStringIsWorthMore.HighestValue("ABCD", "DCBA"), Is.EqualTo("ABCD"));
            Assert.That(WhichStringIsWorthMore.HighestValue("", "Abc"), Is.EqualTo("Abc"));
        }
    }
}
