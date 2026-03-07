using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class TwiceLinearTest
{
    [TestCase(10, 22)]
    [TestCase(20, 57)]
    [TestCase(30, 91)]
    [TestCase(50, 175)]
    [TestCase(100, 447)]
    [TestCase(500, 3355)]
    [TestCase(1000, 8488)]
    [TestCase(2000, 19773)]
    [TestCase(6000, 80914)]
    [TestCase(60000, 1511311)]
    public static void SampleTest(int input, int expected)
    {
        String message = "for n = " + input + "\n";
        int actual = TwiceLinear.DblLinear(input);
        Assert.That(actual, Is.EqualTo(expected), message);
    }
}
