using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class SimpleStringMatchingTest
{
    [Test]
    public void SampleTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(SimpleStringMatching.Solve("code*s", "codewars"), Is.True);
            Assert.That(SimpleStringMatching.Solve("codewar*s", "codewars"), Is.True);
            Assert.That(SimpleStringMatching.Solve("*c", "c"), Is.True);
            Assert.That(SimpleStringMatching.Solve("*", "asterisk"), Is.True);
            Assert.That(SimpleStringMatching.Solve("get*", "getreal"), Is.True);
            Assert.That(SimpleStringMatching.Solve("*less", "restless"), Is.True);
            Assert.That(SimpleStringMatching.Solve("d*oll", "dual"), Is.False);
            Assert.That(SimpleStringMatching.Solve("*osd", "asterisk"), Is.False);
            Assert.That(SimpleStringMatching.Solve("*ea", "bean"), Is.False);
            Assert.That(SimpleStringMatching.Solve("a", "b"), Is.False);
        }
    }
}
