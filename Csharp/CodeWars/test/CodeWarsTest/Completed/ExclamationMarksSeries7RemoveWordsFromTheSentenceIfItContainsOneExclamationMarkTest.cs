using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class ExclamationMarksSeries7RemoveWordsFromTheSentenceIfItContainsOneExclamationMarkTest
{
    [Test]
    public void SampleTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(ExclamationMarksSeries7RemoveWordsFromTheSentenceIfItContainsOneExclamationMark.Remove("Hi!"), Is.EqualTo(""));
            Assert.That(ExclamationMarksSeries7RemoveWordsFromTheSentenceIfItContainsOneExclamationMark.Remove("!Hi"), Is.EqualTo(""));
            Assert.That(ExclamationMarksSeries7RemoveWordsFromTheSentenceIfItContainsOneExclamationMark.Remove("Hi! Hi! Hi!"), Is.EqualTo(""));
            Assert.That(ExclamationMarksSeries7RemoveWordsFromTheSentenceIfItContainsOneExclamationMark.Remove("Hi! !Hi Hi!"), Is.EqualTo(""));
            Assert.That(ExclamationMarksSeries7RemoveWordsFromTheSentenceIfItContainsOneExclamationMark.Remove("Hi! Hi!"), Is.EqualTo(""));
            Assert.That(ExclamationMarksSeries7RemoveWordsFromTheSentenceIfItContainsOneExclamationMark.Remove("!Hi!"), Is.EqualTo("!Hi!"));
            Assert.That(ExclamationMarksSeries7RemoveWordsFromTheSentenceIfItContainsOneExclamationMark.Remove("Hi!!!"), Is.EqualTo("Hi!!!"));
            Assert.That(ExclamationMarksSeries7RemoveWordsFromTheSentenceIfItContainsOneExclamationMark.Remove("Hi Hi! Hi!"), Is.EqualTo("Hi"));
            Assert.That(ExclamationMarksSeries7RemoveWordsFromTheSentenceIfItContainsOneExclamationMark.Remove("Hi hi hI"), Is.EqualTo("Hi hi hI"));
            Assert.That(ExclamationMarksSeries7RemoveWordsFromTheSentenceIfItContainsOneExclamationMark.Remove("Hi! Hi!! Hi!"), Is.EqualTo("Hi!!"));
            Assert.That(ExclamationMarksSeries7RemoveWordsFromTheSentenceIfItContainsOneExclamationMark.Remove("Hi! !Hi! Hi!"), Is.EqualTo("!Hi!"));
            Assert.That(ExclamationMarksSeries7RemoveWordsFromTheSentenceIfItContainsOneExclamationMark.Remove("!Hi! ! !Hi!"), Is.EqualTo("!Hi! !Hi!"));
            Assert.That(ExclamationMarksSeries7RemoveWordsFromTheSentenceIfItContainsOneExclamationMark.Remove("!!!Hi !!hi!!! !hi"), Is.EqualTo("!!!Hi !!hi!!!"));
        }
    }
}
