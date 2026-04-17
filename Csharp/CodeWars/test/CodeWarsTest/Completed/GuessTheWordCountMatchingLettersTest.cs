using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class GuessTheWordCountMatchingLettersTest
{
    [TestCase("dog", "car", 0)]
    [TestCase("dog", "god", 1)]
    [TestCase("dog", "cog", 2)]
    [TestCase("dog", "cod", 1)]
    [TestCase("dog", "bog", 2)]
    [TestCase("dog", "dog", 3)]
    public void GuesserTest(string correctWord, string guess, int expected)
    {
        Assert.That(GuessTheWordCountMatchingLetters.CountCorrectCharacters(correctWord, guess), Is.EqualTo(expected));
    }
}