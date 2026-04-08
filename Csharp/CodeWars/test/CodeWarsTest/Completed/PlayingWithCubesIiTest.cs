using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class PlayingWithCubesIiTest
{
    [Test]
    public static void TestConstructor()
    {
        Cube c = new(10);
        Assert.That(c.GetSide(), Is.EqualTo(10), "Should be 10");
    }
}
