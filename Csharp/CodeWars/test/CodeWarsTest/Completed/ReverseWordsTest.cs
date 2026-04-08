using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class ReverseWordsTest
{
    [Test]
    [Order(1)]
    public void Example()
    {
        Assert.That(ReverseWordsClass.ReverseWords("This is an example!"), Is.EqualTo("sihT si na !elpmaxe"));
    }
    [Test]
    [Order(2)]
    public void QuickBrownFox()
    {
        Assert.That(ReverseWordsClass.ReverseWords("The quick brown fox jumps over the lazy dog."), Is.EqualTo("ehT kciuq nworb xof spmuj revo eht yzal .god"));
    }
    [Test]
    [Order(3)]
    public void OneWord()
    {
        Assert.That(ReverseWordsClass.ReverseWords("apple"), Is.EqualTo("elppa"));
    }
    [Test]
    [Order(4)]
    public void DoubleSpaces()
    {
        Assert.That(ReverseWordsClass.ReverseWords("  double  spaced  words  "), Is.EqualTo("  elbuod  decaps  sdrow  "));
    }
}
