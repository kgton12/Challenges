using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class SumOfNumbersFrom0ToNTest
{
    [Test]
    public void BasicTests()
    {
        Assert.That(SumOfNumbersFrom0ToN.ShowSequence(6), Is.EqualTo("0+1+2+3+4+5+6 = 21"));
    }
}
