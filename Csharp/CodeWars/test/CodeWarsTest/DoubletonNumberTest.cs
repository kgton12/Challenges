using CodeWars;

namespace CodeWarsTest;

public class DoubletonNumberTest
{
    private static void Act(int num, int expected)
    {
        var actual = DoubletonNumber.Doubleton(num);
        Assert.That(actual, Is.EqualTo(expected), $"Input: num = {num}");
    }

    [Test(Description = "Fixed Tests")]
    public void FixedTests()
    {
        Act(120, 121);
        Act(1234, 1311);
        Act(1, 10);
        Act(10, 12);
    }
}
