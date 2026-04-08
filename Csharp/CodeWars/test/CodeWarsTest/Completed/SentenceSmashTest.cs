using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class SentenceSmashTest
{
    [Test]
    public void SampleTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(SentenceSmash.Smash(["hello"]), Is.EqualTo("hello"));
            Assert.That(SentenceSmash.Smash(["hello", "world"]), Is.EqualTo("hello world"));
            Assert.That(SentenceSmash.Smash(["hello", "amazing", "world"]), Is.EqualTo("hello amazing world"));
            Assert.That(SentenceSmash.Smash(["this", "is", "a", "really", "long", "sentence"]), Is.EqualTo("this is a really long sentence"));
            Assert.That(SentenceSmash.Smash([""]), Is.EqualTo(""));
        }
    }
}
