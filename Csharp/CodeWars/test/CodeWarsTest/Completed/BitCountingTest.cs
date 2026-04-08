using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class BitCountingTest
{
    private static void DoTest(int input, int expected)
    {
        int actual = BitCounting.CountBits(input);
        Assert.That(actual, Is.EqualTo(expected), "for n = " + input);
    }

    [Test, Order(1)]
    public void FixedTests()
    {
        DoTest(0, 0);
        DoTest(4, 1);
        DoTest(7, 3);
        DoTest(12525589, 11);
        DoTest(3811, 8);
        DoTest(392902058, 17);
        DoTest(1044, 3);
        DoTest(10030245, 10);
        DoTest(89, 4);
        DoTest(674259, 10);
        DoTest(Int32.MaxValue, 31);
    }
}
