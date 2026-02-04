using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class BoiledEggsTest
{
    [Test]
    public void SampleTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(BoiledEggs.CookingTime(0), Is.Zero, "0 eggs");
            Assert.That(BoiledEggs.CookingTime(5), Is.EqualTo(5), "5 eggs");
            Assert.That(BoiledEggs.CookingTime(10), Is.EqualTo(10), "10 eggs");
        }
    }
}
