using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class WhichAreInTest
{
    [Test]
    public void Test1()
    {
        string[] a1 = ["arp", "live", "strong"];
        string[] a2 = ["lively", "alive", "harp", "sharp", "armstrong"];
        string[] r = ["arp", "live", "strong"];
        Assert.That(WhichAreIn.InArray(a1, a2), Is.EqualTo(r));
    }
}
