using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class ExclamationMarksSeries4RemoveAllExclamationMarksFromSentenceButEnsureAExclamationMarkAtTheEndOfStringTest
{
    [Test]
    public void SampleTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(ExclamationMarksSeries4RemoveAllExclamationMarksFromSentenceButEnsureAExclamationMarkAtTheEndOfString.Remove("Hi!"), Is.EqualTo("Hi!"));
            Assert.That(ExclamationMarksSeries4RemoveAllExclamationMarksFromSentenceButEnsureAExclamationMarkAtTheEndOfString.Remove("Hi!!!"), Is.EqualTo("Hi!"));
            Assert.That(ExclamationMarksSeries4RemoveAllExclamationMarksFromSentenceButEnsureAExclamationMarkAtTheEndOfString.Remove("!Hi"), Is.EqualTo("Hi!"));
            Assert.That(ExclamationMarksSeries4RemoveAllExclamationMarksFromSentenceButEnsureAExclamationMarkAtTheEndOfString.Remove("!Hi!"), Is.EqualTo("Hi!"));
            Assert.That(ExclamationMarksSeries4RemoveAllExclamationMarksFromSentenceButEnsureAExclamationMarkAtTheEndOfString.Remove("Hi! Hi!"), Is.EqualTo("Hi Hi!"));
            Assert.That(ExclamationMarksSeries4RemoveAllExclamationMarksFromSentenceButEnsureAExclamationMarkAtTheEndOfString.Remove("Hi"), Is.EqualTo("Hi!"));
        }
    }
}
