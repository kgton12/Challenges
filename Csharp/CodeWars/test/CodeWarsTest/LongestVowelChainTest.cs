using CodeWars.Resolutions;

namespace CodeWarsTest;

public class LongestVowelChainTest
{
    [Test, Description("Basic Tests")]
    public void SampleTest()
    {
        Assert.That(LongestVowelChain.Solve("codewarriors"), Is.EqualTo(2));
        Assert.That(LongestVowelChain.Solve("suoidea"), Is.EqualTo(3));
        Assert.That(LongestVowelChain.Solve("ultrarevolutionariees"), Is.EqualTo(3));
        Assert.That(LongestVowelChain.Solve("strengthlessnesses"), Is.EqualTo(1));
        Assert.That(LongestVowelChain.Solve("cuboideonavicuare"), Is.EqualTo(2));
        Assert.That(LongestVowelChain.Solve("chrononhotonthuooaos"), Is.EqualTo(5));
        Assert.That(LongestVowelChain.Solve("iiihoovaeaaaoougjyaw"), Is.EqualTo(8));
    }
}
