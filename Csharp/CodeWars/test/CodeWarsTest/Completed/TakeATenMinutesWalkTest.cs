using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class TakeATenMinutesWalkTest
{
    [Test]
    [Order(1)]
    public void SampleTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(TakeaTenMinutesWalk.IsValidWalk(["n", "s", "n", "s", "n", "s", "n", "s", "n", "s"]), Is.True, "should return true");
            Assert.That(TakeaTenMinutesWalk.IsValidWalk(["w", "e", "w", "e", "w", "e", "w", "e", "w", "e", "w", "e"]), Is.False, "should return false");
            Assert.That(TakeaTenMinutesWalk.IsValidWalk(["w"]), Is.False, "should return false");
            Assert.That(TakeaTenMinutesWalk.IsValidWalk(["n", "n", "n", "s", "n", "s", "n", "s", "n", "s"]), Is.False, "should return false");
        }
    }
}
