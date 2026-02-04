using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class SumOfOddCubedNumbersTest
{
    [Test]
    public void SampleTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(SumofOddCubedNumbers.CubeOdd([1, 2, 3, 4]), Is.EqualTo(28));
            Assert.That(SumofOddCubedNumbers.CubeOdd([-3, -2, 2, 3]), Is.Zero);
        }
    }
}
