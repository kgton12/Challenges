using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class AveragesOfNumbersTest
{
    [Test]
    public void BasicTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(string.Join(", ", AveragesOfNumbers.Averages([2, 2, 2, 2, 2])), Is.EqualTo(string.Join(", ", new double[] { 2, 2, 2, 2 })));
            Assert.That(string.Join(", ", AveragesOfNumbers.Averages([2, -2, 2, -2, 2])), Is.EqualTo(string.Join(", ", new double[] { 0, 0, 0, 0 })));
            Assert.That(string.Join(", ", AveragesOfNumbers.Averages([1, 3, 5, 1, -10])), Is.EqualTo(string.Join(", ", new double[] { 2, 4, 3, -4.5 })));
        }
    }
}
