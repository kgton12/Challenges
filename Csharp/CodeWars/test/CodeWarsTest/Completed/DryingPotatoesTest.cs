using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class DryingPotatoesTest
{
    private static void Dotest(int p0, int w0, int p1, int expected)
    {
        Assert.That(DryingPotatoes.Potatoes(p0, w0, p1), Is.EqualTo(expected));
    }

    [Test]
    public static void Test()
    {
        Dotest(82, 127, 80, 114);
        Dotest(93, 129, 91, 100);
    }
}
