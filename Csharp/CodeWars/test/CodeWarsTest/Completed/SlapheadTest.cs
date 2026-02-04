using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class SlapheadTest
{
    [Test]
    public void BasicTests()
    {
        Assert.That(Slaphead.Bald("/---------"), Is.EqualTo(new string[] { "----------", "Unicorn!" }));
        Assert.That(Slaphead.Bald("/-----/-"), Is.EqualTo(new string[] { "--------", "Homer!" }));
        Assert.That(Slaphead.Bald("--/--/---/-/---"), Is.EqualTo(new string[] { "---------------", "Careless!" }));
    }
}
