using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class LeapYearsTest
{
    [Test]
    public static void TestYear2020()
    {
        Assert.That(LeapYears.IsLeapYear(2020), Is.True, "Incorrect answer for year=2020");
    }

    [Test]
    public static void TestYear2000()
    {
        Assert.That(LeapYears.IsLeapYear(2000), Is.True, "Incorrect answer for year=2000");
    }

    [Test]
    public static void TestYear2015()
    {
        Assert.That(LeapYears.IsLeapYear(2015), Is.False, "Incorrect answer for year=2015");
    }


    [Test]
    public static void TestYear2100()
    {
        Assert.That(LeapYears.IsLeapYear(2100), Is.False, "Incorrect answer for year=2100");
    }
}
