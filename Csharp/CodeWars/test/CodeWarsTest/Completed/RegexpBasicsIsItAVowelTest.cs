using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class RegexpBasicsIsItAVowelTest
{
    [Test]
    public void BasicTests()
    {
        Assert.That("".Vowel(), Is.EqualTo(false));
        Assert.That("a".Vowel(), Is.EqualTo(true));
        Assert.That("E".Vowel(), Is.EqualTo(true));
        Assert.That("ou".Vowel(), Is.EqualTo(false));
        Assert.That("z".Vowel(), Is.EqualTo(false));
        Assert.That("lol".Vowel(), Is.EqualTo(false));
    }
}
