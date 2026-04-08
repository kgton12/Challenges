using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class PullYourWordsTogetherManTest
{
    [Test, Description("Sample Tests")]
    public void SampleTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(PullYourWordsTogetherMan.Sentencify(["i", "am", "an", "AI"]), Is.EqualTo("I am an AI."));
            Assert.That(PullYourWordsTogetherMan.Sentencify(["yes"]), Is.EqualTo("Yes."));
            Assert.That(PullYourWordsTogetherMan.Sentencify(["FIELDS", "of", "CORN", "are", "to", "be", "sown"]), Is.EqualTo("FIELDS of CORN are to be sown."));
            Assert.That(PullYourWordsTogetherMan.Sentencify(["i'm", "afraid", "I", "can't", "let", "you", "do", "that"]), Is.EqualTo("I'm afraid I can't let you do that."));
        }
    }
}
