using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class TheFallingSpeedOfPetalsTest
{
    [Test]
    public void SampleTest()
    {
        Assert.That(
            TheFallingSpeedOfPetals.SakuraFall(5),
            Is.EqualTo(80).Within(1e-6));
    }
}
