using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class AreTheyTheSameTest
{
    [Test]
    public void Test1()
    {
        int[] a = [121, 144, 19, 161, 19, 144, 19, 11];
        int[] b = [11 * 11, 121 * 121, 144 * 144, 19 * 19, 161 * 161, 19 * 19, 144 * 144, 19 * 19];
        bool r = AreTheyTheSame.Comp(a, b);
        Assert.That(r, Is.True);
    }
}
