using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class ExclamationMarksSeries3RemoveAllExclamationMarksFromSentenceExceptAtTheEndTest
{
    [Test, Description("It should work for basic tests")]
    public void SampleTest()
    {
        Assert.That(ExclamationMarksSeries3RemoveAllExclamationMarksFromSentenceExceptAtTheEnd.Remove("Hi!"), Is.EqualTo("Hi!"));
        Assert.That(ExclamationMarksSeries3RemoveAllExclamationMarksFromSentenceExceptAtTheEnd.Remove("Hi!!!"), Is.EqualTo("Hi!!!"));
        Assert.That(ExclamationMarksSeries3RemoveAllExclamationMarksFromSentenceExceptAtTheEnd.Remove("!Hi"), Is.EqualTo("Hi"));
        Assert.That(ExclamationMarksSeries3RemoveAllExclamationMarksFromSentenceExceptAtTheEnd.Remove("!Hi!"), Is.EqualTo("Hi!"));
        Assert.That(ExclamationMarksSeries3RemoveAllExclamationMarksFromSentenceExceptAtTheEnd.Remove("Hi! Hi!"), Is.EqualTo("Hi Hi!"));
        Assert.That(ExclamationMarksSeries3RemoveAllExclamationMarksFromSentenceExceptAtTheEnd.Remove("Hi"), Is.EqualTo("Hi"));
    }
}