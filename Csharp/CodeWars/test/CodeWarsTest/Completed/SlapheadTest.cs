using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class SlapheadTest
{
    [Test]
    public void BasicTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(Slaphead.Bald("/---------"), Is.EqualTo(["----------", "Unicorn!"]));
            Assert.That(Slaphead.Bald("/-----/-"), Is.EqualTo(["--------", "Homer!"]));
            Assert.That(Slaphead.Bald("--/--/---/-/---"), Is.EqualTo(["---------------", "Careless!"]));
        }
    }
}
