using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class HowGoodAreYouReallyTest
{
    private static void DoTest(int[] grades, int userGrade, bool expected)
    {
        String message = "your grade = " + userGrade + "; class grades = {" + String.Join(", ", grades) + "}";
        bool actual = HowGoodAreYouReally.BetterThanAverage(grades, userGrade);
        Assert.That(actual, Is.EqualTo(expected), message);
    }

    [Test]
    public static void FixedTests()
    {
        DoTest([2, 3], 5, true);
        DoTest([100, 40, 34, 57, 29, 72, 57, 88], 75, true);
        DoTest([12, 23, 34, 45, 56, 67, 78, 89, 90], 69, true);
        DoTest([100, 90], 11, false);
    }
}
