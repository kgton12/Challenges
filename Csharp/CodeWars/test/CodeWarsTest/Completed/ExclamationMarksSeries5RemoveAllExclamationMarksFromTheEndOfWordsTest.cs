using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class ExclamationMarksSeries5RemoveAllExclamationMarksFromTheEndOfWordsTest
{
    [Test, Description("It should work for basic tests")]
    [TestCase("Hi", "Hi!", TestName = "Input: \"Hi!\"")]
    [TestCase("Hi", "Hi!!!", TestName = "Input: \"Hi!!!\"")]
    [TestCase("!Hi", "!Hi", TestName = "Input: \"!Hi\"")]
    [TestCase("!Hi", "!Hi!", TestName = "Input: \"!Hi!\"")]
    [TestCase("Hi Hi", "Hi! Hi", TestName = "Input: \"Hi! Hi\"")]
    [TestCase("!!!Hi !!hi !hi", "!!!Hi !!hi!!! !hi", TestName = "Input: \"!!!Hi !!hi!!! !hi\"")]
    public void SampleTest(String expected, String input)
    {
        Assert.That(ExclamationMarksSeries5RemoveAllExclamationMarksFromTheEndOfWords.Remove(input), Is.EqualTo(expected));
    }
}
