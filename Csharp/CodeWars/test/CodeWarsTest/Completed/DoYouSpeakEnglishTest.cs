using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class DoYouSpeakEnglishTest
{
    [TestCase("hello world", false)]
    [TestCase("egnlish", false)]
    [TestCase("", false)]
    [TestCase("english", true)]
    [TestCase("1234english ;k", true)]
    [TestCase("I speak English", true)]
    [TestCase("ABC123DOREME", false)]
    [TestCase("eNgliSh", true)]
    [TestCase("1234#$%%eNglish ;k9", true)]
    [TestCase("spanish, english, french", true)]
    [TestCase("englishENGLISHEnGlISHENglisH", true)]
    [TestCase("HeLlO tHeR3 enGLiSh MuffIN", true)]
    public void SampleTests(string str, bool expected)
    {
        var actual = DoYouSpeakEnglish.SpeakEnglish(str);
        Assert.That(actual, Is.EqualTo(expected), $"Input: \"{str}\"");
    }
}
