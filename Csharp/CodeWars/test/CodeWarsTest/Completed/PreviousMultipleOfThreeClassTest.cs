using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class PreviousMultipleOfThreeClassTest
{
    private static void Act(int n, int? expected)
    {
        var msg = $"Invalid answer for n: {n}";
        var actual = PreviousMultipleOfThreeClass.PreviousMultipleOfThree(n);
        Assert.That(actual, Is.EqualTo(expected), msg);
    }

    [TestCase(1, null)]
    [TestCase(25, null)]
    [TestCase(36, 36)]
    [TestCase(1244, 12)]
    [TestCase(952406, 9)]
    public void SampleTests(int n, int? expected)
    {
        Act(n, expected);
    }
}
