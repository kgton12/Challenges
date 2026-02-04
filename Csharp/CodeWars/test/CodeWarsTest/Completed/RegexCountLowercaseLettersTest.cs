using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class RegexCountLowercaseLettersTest
{
    [Test]
    [TestCase("abc", ExpectedResult = 3)]
    [TestCase("abcABC123", ExpectedResult = 3)]
    [TestCase("abcABC123!@€£#$%^&*()_-+=}{[]|\':;?/>.<,~", ExpectedResult = 3)]
    [TestCase("", ExpectedResult = 0)]
    [TestCase("ABC123!@€£#$%^&*()_-+=}{[]|\':;?/>.<,~", ExpectedResult = 0)]
    [TestCase("abcdefghijklmnopqrstuvwxyz", ExpectedResult = 26)]
    public static int FixedTest(string str)
    {
        return RegexCountLowercaseLetters.LowercaseCountCheck(str);
    }
}
