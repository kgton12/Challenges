using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class RegexpBasicsIsItAVowelTest
{
    [Test]
    public void BasicTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That("".Vowel(), Is.False);
            Assert.That("a".Vowel(), Is.True);
            Assert.That("E".Vowel(), Is.True);
            Assert.That("ou".Vowel(), Is.False);
            Assert.That("z".Vowel(), Is.False);
            Assert.That("lol".Vowel(), Is.False);
        }
    }
}
