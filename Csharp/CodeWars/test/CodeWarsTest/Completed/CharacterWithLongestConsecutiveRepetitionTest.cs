using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class CharacterWithLongestConsecutiveRepetitionTest
{
    [Test]
    public void LongestAtTheBeginning()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(CharacterWithLongestConsecutiveRepetition.LongestRepetition("aaaabb"), Is.EqualTo(new Tuple<char?, int>('a', 4)));
            Assert.That(CharacterWithLongestConsecutiveRepetition.LongestRepetition("abbbbb"), Is.EqualTo(new Tuple<char?, int>('b', 5)));
        }
    }

    [Test]
    public void LongestAtTheEnd()
    {
        Assert.That(CharacterWithLongestConsecutiveRepetition.LongestRepetition("bbbaaabaaaa"), Is.EqualTo(new Tuple<char?, int>('a', 4)));
    }

    [Test]
    public void LongestInTheMiddle()
    {
        Assert.That(CharacterWithLongestConsecutiveRepetition.LongestRepetition("cbdeuuu900"), Is.EqualTo(new Tuple<char?, int>('u', 3)));
    }

    [Test]
    public void MultipleLongest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(CharacterWithLongestConsecutiveRepetition.LongestRepetition("aabb"), Is.EqualTo(new Tuple<char?, int>('a', 2)));
            Assert.That(CharacterWithLongestConsecutiveRepetition.LongestRepetition("ba"), Is.EqualTo(new Tuple<char?, int>('b', 1)));
        }
    }

    [Test]
    public void EmptyString()
    {
        Assert.That(CharacterWithLongestConsecutiveRepetition.LongestRepetition(""), Is.EqualTo(new Tuple<char?, int>(null, 0)));
    }
}
