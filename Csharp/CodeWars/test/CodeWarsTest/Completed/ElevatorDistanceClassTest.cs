using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class ElevatorDistanceClassTest
{
    private static void Act(int[] array, int expected)
    {
        var msg = $"Invalid answer for array: [{string.Join(",", array)}]";
        var actual = ElevatorDistanceClass.ElevatorDistance(array);
        Assert.That(actual, Is.EqualTo(expected), msg);
    }

    [TestCase(new[] { 5, 2, 8 }, 9)]
    [TestCase(new[] { 1, 2, 3 }, 2)]
    [TestCase(new[] { 7, 1, 7, 1 }, 18)]
    public void FixedTests(int[] array, int expected)
    {
        Act(array, expected);
    }
}
