using CodeWars.Completed;

namespace CodeWarsTest.Completed;

[TestFixture]

public class FirstNonRepeatingCharacterTest
{
    [Test]
    public void BasicTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(FirstNonRepeatingCharacter.FirstNonRepeatingLetter("a"), Is.EqualTo("a"));
            Assert.That(FirstNonRepeatingCharacter.FirstNonRepeatingLetter("stress"), Is.EqualTo("t"));
            Assert.That(FirstNonRepeatingCharacter.FirstNonRepeatingLetter("moonmen"), Is.EqualTo("e"));
        }
    }

    [Test]
    public void EmptyTest()
    {
        Assert.That(FirstNonRepeatingCharacter.FirstNonRepeatingLetter(""), Is.EqualTo(""));
    }

    [Test]
    public void AllRepeatingTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(FirstNonRepeatingCharacter.FirstNonRepeatingLetter("abba"), Is.EqualTo(""));
            Assert.That(FirstNonRepeatingCharacter.FirstNonRepeatingLetter("aa"), Is.EqualTo(""));
        }
    }

    [Test]
    public void OddCharactersTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(FirstNonRepeatingCharacter.FirstNonRepeatingLetter("∞§ﬁ›ﬂ∞§"), Is.EqualTo("ﬁ"));
            Assert.That(FirstNonRepeatingCharacter.FirstNonRepeatingLetter("hello world, eh?"), Is.EqualTo("w"));
        }
    }

    [Test]
    public void CaseLettersTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(FirstNonRepeatingCharacter.FirstNonRepeatingLetter("sTreSS"), Is.EqualTo("T"));
            Assert.That(FirstNonRepeatingCharacter.FirstNonRepeatingLetter("Go hang a salami, I'm a lasagna hog!"), Is.EqualTo(","));
        }
    }
}
