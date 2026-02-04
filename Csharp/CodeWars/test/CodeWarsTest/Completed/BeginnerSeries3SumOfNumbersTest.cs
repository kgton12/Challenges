using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class BeginnerSeries3SumOfNumbersTest
{
    [Test]
    public void Test1()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(BeginnerSeries3SumOfNumbers.GetSum(0, 1), Is.EqualTo(1));
            Assert.That(BeginnerSeries3SumOfNumbers.GetSum(0, -1), Is.EqualTo(-1));
        }
    }
}
