using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class DigitalCypherVol2Test
{
    [Test]
    public void BasicTest()
    {
        Assert.That(DigitalCypherVol2.Decode(new int[] { 20, 12, 18, 30, 21 }, 1939), Is.EqualTo("scout"));
        Assert.That(DigitalCypherVol2.Decode(new int[] { 14, 10, 22, 29, 6, 27, 19, 18, 6, 12, 8 }, 1939), Is.EqualTo("masterpiece"));
    }
}
