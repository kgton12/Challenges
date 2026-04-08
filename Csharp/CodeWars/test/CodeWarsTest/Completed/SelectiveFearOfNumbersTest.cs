using static CodeWars.Completed.SelectiveFearOfNumbers;

namespace CodeWarsTest.Completed;

public class SelectiveFearOfNumbersTest
{
    private static void Tester(string day, int num, bool expected)
    {
        bool submitted = AmIAfraid(day, num);
        string message = $"day = \"{day}\"\n  num = {num}";
        Assert.That(submitted, Is.EqualTo(expected), message);
    }

    [Test]
    public static void TestFixed()
    {
        Tester(DaysWeek.Monday.ToString(), 13, false);
        Tester(DaysWeek.Sunday.ToString(), -666, true);
        Tester(DaysWeek.Tuesday.ToString(), 2, false);
        Tester(DaysWeek.Tuesday.ToString(), 965, true);
        Tester(DaysWeek.Friday.ToString(), 2, true);
    }
}
