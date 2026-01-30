using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class AllStarCodeChallenge18Test
{
    [TestCase("Hello", 'o', 1)]
    [TestCase("Hello", 'l', 2)]
    [TestCase("Hello", 'p', 0)]
    [TestCase("", 'z', 0)]
    public void BasicTests(string str, char letter, int expected)
    {
        Assert.That(AllStarCodeChallenge18.StrCount(str, letter), Is.EqualTo(expected));
    }
}
