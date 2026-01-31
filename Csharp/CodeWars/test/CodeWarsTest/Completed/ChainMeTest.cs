using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class ChainMeTest
{
    private static double Add(double x) { return x + 10; }
    private static double Mul(double x) { return x * 30; }

    [Test]
    public static void ExampleTest()
    {
        Assert.That(ChainMe.Chain(2, new[] { Add, Mul }), Is.EqualTo(360), "Incorrect Value for '2'");
    }
}
