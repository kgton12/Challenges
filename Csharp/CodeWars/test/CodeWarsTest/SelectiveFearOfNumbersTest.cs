using CodeWars;

namespace CodeWarsTest;

public class SelectiveFearOfNumbersTest
{
    private static void Tester(string day, int num, bool expected)
    {
        bool submitted = SelectiveFearOfNumbers.AmIAfraid(day, num);
        string message = $"day = \"{day}\"\n  num = {num}";
        Assert.That(submitted, Is.EqualTo(expected), message);
    }

    [Test]
    public static void TestFixed()
    {
        Tester("Monday", 13, false);
        Tester("Sunday", -666, true);
        Tester("Tuesday", 2, false);
        Tester("Tuesday", 965, true);
        Tester("Friday", 2, true);
    }
}
