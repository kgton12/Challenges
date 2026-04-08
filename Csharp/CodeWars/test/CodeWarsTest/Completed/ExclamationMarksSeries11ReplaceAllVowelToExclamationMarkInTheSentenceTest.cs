using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class ExclamationMarksSeries11ReplaceAllVowelToExclamationMarkInTheSentenceTest
{
    [Test, Description("Basic Tests")]
    public void BasicTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(ExclamationMarksSeries11ReplaceAllVowelToExclamationMarkInTheSentence.Replace("Hi!"), Is.EqualTo("H!!"));
            Assert.That(ExclamationMarksSeries11ReplaceAllVowelToExclamationMarkInTheSentence.Replace("!Hi! Hi!"), Is.EqualTo("!H!! H!!"));
            Assert.That(ExclamationMarksSeries11ReplaceAllVowelToExclamationMarkInTheSentence.Replace("aeiou"), Is.EqualTo("!!!!!"));
            Assert.That(ExclamationMarksSeries11ReplaceAllVowelToExclamationMarkInTheSentence.Replace("ABCDE"), Is.EqualTo("!BCD!"));
        }
    }
}
