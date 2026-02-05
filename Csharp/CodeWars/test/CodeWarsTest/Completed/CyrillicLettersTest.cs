using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class CyrillicLettersTest
{
    [Description("Cyrillic letters")]
    [TestCase('Д', Description = "'Д'")]
    [TestCase('а', Description = "'а'")]
    public void TestCyrillicLetters(char c)
    {
        Assert.That(CyrillicLetters.IsCyrillic(c), Is.True, $"Incorrect answer for letter = {c}");
    }

    [Description("Non-Cyrillic letters")]
    [TestCase('D', Description = "'D'")]
    [TestCase('a', Description = "'a'")]
    public void TestNonCyrillicLetters(char c)
    {
        Assert.That(CyrillicLetters.IsCyrillic(c), Is.False, $"Incorrect answer for letter = {c}");
    }
}
