using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class CalculateAverageTest
{
    [Test]
    public void SampleTests()
    {
        DoTest([1, 2, 3], 2.0);
        DoTest([5, 5, 5, 5], 5.0);
        DoTest([2, 3, 6, 7, 1], 3.8);
    }

    private static void DoTest(double[] input, double expected)
    {
        String message = String.Format("for array = [{0}]\n", String.Join(", ", input));
        double actual = CalculateAverage.FindAverage(input);
        Assert.That(actual, Is.EqualTo(expected).Within(1e-3), message);
    }
}
