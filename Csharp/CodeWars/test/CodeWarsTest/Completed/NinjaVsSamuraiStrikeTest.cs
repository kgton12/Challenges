using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class NinjaVsSamuraiStrikeTest
{
    private readonly NinjaVsSamuraiStrike ninja = new("Ninja");
    private readonly NinjaVsSamuraiStrike samurai = new("Samurai");

    [Test]
    public void Tests()
    {
        samurai.Strike(ninja, 4);
        Assert.That(ninja.Health, Is.EqualTo(60));
    }
}
