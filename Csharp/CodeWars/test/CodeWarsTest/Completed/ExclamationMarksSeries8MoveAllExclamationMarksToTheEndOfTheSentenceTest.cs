using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class ExclamationMarksSeries8MoveAllExclamationMarksToTheEndOfTheSentenceTest
{
    [Test]
    public void SampleTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(ExclamationMarksSeries8MoveAllExclamationMarksToTheEndOfTheSentence.Remove("Hi!"), Is.EqualTo("Hi!"));
            Assert.That(ExclamationMarksSeries8MoveAllExclamationMarksToTheEndOfTheSentence.Remove("Hi! Hi!"), Is.EqualTo("Hi Hi!!"));
            Assert.That(ExclamationMarksSeries8MoveAllExclamationMarksToTheEndOfTheSentence.Remove("Hi! Hi! Hi!"), Is.EqualTo("Hi Hi Hi!!!"));
            Assert.That(ExclamationMarksSeries8MoveAllExclamationMarksToTheEndOfTheSentence.Remove("Hi! !Hi Hi!"), Is.EqualTo("Hi Hi Hi!!!"));
        }
        Assert.That(ExclamationMarksSeries8MoveAllExclamationMarksToTheEndOfTheSentence.Remove("Hi! !Hi Hi!"), Is.EqualTo("Hi Hi Hi!!!"));
        Assert.That(ExclamationMarksSeries8MoveAllExclamationMarksToTheEndOfTheSentence.Remove("Hi! Hi!! Hi!"), Is.EqualTo("Hi Hi Hi!!!!"));
    }
}
