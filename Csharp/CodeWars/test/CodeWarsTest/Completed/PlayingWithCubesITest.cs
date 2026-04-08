using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class PlayingWithCubesITest
{
    [Test]
    public static void FixedTest()
    {
        Cube c = new Cube();
        Assert.That(c.GetSide(), Is.EqualTo(0), "when not set before, Side should be 0");
        c.SetSide(5);
        Assert.That(c.GetSide(), Is.EqualTo(5), "Should return 5");
    }
}
