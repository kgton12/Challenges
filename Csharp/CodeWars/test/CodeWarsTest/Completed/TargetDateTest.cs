using CodeWars.Completed;

namespace CodeWarsTest;

public class TargetDateTest
{
    private static void Testing(string actual, string expected)
    {
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public static void Test1()
    {
        Testing(TargetDate.DateNbDays(4281, 5087, 2), "2024-07-03");
        Testing(TargetDate.DateNbDays(4620, 5188, 2), "2021-09-19");
        Testing(TargetDate.DateNbDays(9999, 11427, 6), "2018-03-13");
        Testing(TargetDate.DateNbDays(3525, 4822, 3), "2026-04-18");
        Testing(TargetDate.DateNbDays(5923, 6465, 6), "2017-06-10");
        Testing(TargetDate.DateNbDays(4254, 4761, 8), "2017-05-22");
        Testing(TargetDate.DateNbDays(1244, 2566, 4), "2033-11-04");
        Testing(TargetDate.DateNbDays(6328, 7517, 5), "2019-05-25");
        Testing(TargetDate.DateNbDays(2920, 3834, 2), "2029-06-03");
        Testing(TargetDate.DateNbDays(7792, 8987, 4), "2019-07-09");
    }
}