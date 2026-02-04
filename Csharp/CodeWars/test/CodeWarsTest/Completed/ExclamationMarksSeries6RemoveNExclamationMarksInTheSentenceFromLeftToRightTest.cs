using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class ExclamationMarksSeries6RemoveNExclamationMarksInTheSentenceFromLeftToRightTest
{
    [Test, Description("It should work for basic tests")]
    public void SampleTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(ExclamationMarksSeries6RemoveNExclamationMarksInTheSentenceFromLeftToRight.Remove("Hi!", 1), Is.EqualTo("Hi"));
            Assert.That(ExclamationMarksSeries6RemoveNExclamationMarksInTheSentenceFromLeftToRight.Remove("Hi!", 100), Is.EqualTo("Hi"));
            Assert.That(ExclamationMarksSeries6RemoveNExclamationMarksInTheSentenceFromLeftToRight.Remove("Hi!!!", 1), Is.EqualTo("Hi!!"));
            Assert.That(ExclamationMarksSeries6RemoveNExclamationMarksInTheSentenceFromLeftToRight.Remove("Hi!!!", 100), Is.EqualTo("Hi"));
            Assert.That(ExclamationMarksSeries6RemoveNExclamationMarksInTheSentenceFromLeftToRight.Remove("!Hi", 1), Is.EqualTo("Hi"));
            Assert.That(ExclamationMarksSeries6RemoveNExclamationMarksInTheSentenceFromLeftToRight.Remove("!Hi!", 1), Is.EqualTo("Hi!"));
            Assert.That(ExclamationMarksSeries6RemoveNExclamationMarksInTheSentenceFromLeftToRight.Remove("!Hi!", 100), Is.EqualTo("Hi"));
            Assert.That(ExclamationMarksSeries6RemoveNExclamationMarksInTheSentenceFromLeftToRight.Remove("!!!Hi !!hi!!! !hi", 1), Is.EqualTo("!!Hi !!hi!!! !hi"));
            Assert.That(ExclamationMarksSeries6RemoveNExclamationMarksInTheSentenceFromLeftToRight.Remove("!!!Hi !!hi!!! !hi", 3), Is.EqualTo("Hi !!hi!!! !hi"));
            Assert.That(ExclamationMarksSeries6RemoveNExclamationMarksInTheSentenceFromLeftToRight.Remove("!!!Hi !!hi!!! !hi", 5), Is.EqualTo("Hi hi!!! !hi"));
            Assert.That(ExclamationMarksSeries6RemoveNExclamationMarksInTheSentenceFromLeftToRight.Remove("!!!Hi !!hi!!! !hi", 100), Is.EqualTo("Hi hi hi"));
        }
    }
}
