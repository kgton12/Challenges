using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class ConsonantValueTest
{
    [TestCase("zodiac", 26)]
    [TestCase("chruschtschov", 80)]
    [TestCase("khrushchev", 38)]
    [TestCase("strength", 57)]
    [TestCase("catchphrase", 73)]
    [TestCase("twelfthstreet", 103)]
    [TestCase("mischtschenkoana", 80)]
    public void BasicTests(string input, int expected)
    {
        Assert.That(ConsonantValue.Solve(input), Is.EqualTo(expected));
    }
}
