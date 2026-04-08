using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class FindTheParityOutlierTest
{
    private static void DoTest(int expected, int[] input)
    {
        String message = "for array { " + string.Join(", ", input) + " }\n";
        int actual = FindTheParityOutlier.Find(input);
        Assert.That(actual, Is.EqualTo(expected), message);
    }

    [Test]
    [Order(1)]
    public static void Test1()
    {
        DoTest(3, [2, 6, 8, -10, 3]);
    }

    [Test]
    [Order(2)]
    public static void Test2()
    {
        DoTest(206847684, [206847684, 1056521, 7, 17, 1901, 21104421, 7, 1, 35521, 1, 7781]);
    }

    [Test]
    [Order(3)]
    public static void Test3()
    {
        DoTest(0, [int.MaxValue, 0, 1]);
    }

    [Test]
    [Order(4)]
    public static void Test4()
    {
        DoTest(-5, [-5, 6, 6]);
    }
}
