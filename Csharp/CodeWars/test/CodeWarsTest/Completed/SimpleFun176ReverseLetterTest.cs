using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class SimpleFun176ReverseLetterTest
{
    [Test]
    public void BasicTests()
    {

        Assert.That(SimpleFun176ReverseLetter.ReverseLetter("krishan"), Is.EqualTo("nahsirk"));

        Assert.That(SimpleFun176ReverseLetter.ReverseLetter("ultr53o?n"), Is.EqualTo("nortlu"));

        Assert.That(SimpleFun176ReverseLetter.ReverseLetter("ab23c"), Is.EqualTo("cba"));

        Assert.That(SimpleFun176ReverseLetter.ReverseLetter("krish21an"), Is.EqualTo("nahsirk"));

    }
}
