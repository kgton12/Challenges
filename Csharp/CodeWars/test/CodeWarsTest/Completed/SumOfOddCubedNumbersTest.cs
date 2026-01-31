using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class SumOfOddCubedNumbersTest
{
    [Test]
    public void SampleTest()
    {
        Assert.That(SumofOddCubedNumbers.CubeOdd(new int[] { 1, 2, 3, 4 }), Is.EqualTo(28));
        Assert.That(SumofOddCubedNumbers.CubeOdd(new int[] { -3, -2, 2, 3 }), Is.EqualTo(0));
    }
}
