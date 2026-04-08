using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class PalindromeChainLengthClassTest
{
    [Test]
    public void Given87OutputShouldBe4()
    {
        Assert.That(PalindromeChainLengthClass.PalindromeChainLength(87), Is.EqualTo(4));
    }
}
