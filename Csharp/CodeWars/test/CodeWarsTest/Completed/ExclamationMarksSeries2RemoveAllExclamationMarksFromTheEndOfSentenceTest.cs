using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class ExclamationMarksSeries2RemoveAllExclamationMarksFromTheEndOfSentenceTest
{
    [Test, Description("It should work for basic tests")]
    public void SampleTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(ExclamationMarksSeries2RemoveAllExclamationMarksFromTheEndOfSentence.Remove("Hi!"), Is.EqualTo("Hi"));
            Assert.That(ExclamationMarksSeries2RemoveAllExclamationMarksFromTheEndOfSentence.Remove("Hi!!!"), Is.EqualTo("Hi"));
            Assert.That(ExclamationMarksSeries2RemoveAllExclamationMarksFromTheEndOfSentence.Remove("!Hi"), Is.EqualTo("!Hi"));
            Assert.That(ExclamationMarksSeries2RemoveAllExclamationMarksFromTheEndOfSentence.Remove("!Hi!"), Is.EqualTo("!Hi"));
            Assert.That(ExclamationMarksSeries2RemoveAllExclamationMarksFromTheEndOfSentence.Remove("Hi! Hi"), Is.EqualTo("Hi! Hi"));
            Assert.That(ExclamationMarksSeries2RemoveAllExclamationMarksFromTheEndOfSentence.Remove("Hi"), Is.EqualTo("Hi"));
        }
    }
}
