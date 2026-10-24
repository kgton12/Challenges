using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class ReverseWordsTest
{
    [Test]
    public void Example()
    {
        Assert.That(ReverseWordsClass.ReverseWords("This is an example!"), Is.EqualTo("sihT si na !elpmaxe"));
    }
    [Test]
    public void QuickBrownFox()
    {
        Assert.That(ReverseWordsClass.ReverseWords("The quick brown fox jumps over the lazy dog."), Is.EqualTo("ehT kciuq nworb xof spmuj revo eht yzal .god"));
    }
    [Test]
    public void OneWord()
    {
        Assert.That(ReverseWordsClass.ReverseWords("apple"), Is.EqualTo("elppa"));
    }
    [Test]
    public void DoubleSpaces()
    {
        Assert.That(ReverseWordsClass.ReverseWords("  double  spaced  words  "), Is.EqualTo("  elbuod  decaps  sdrow  "));
    }
}
