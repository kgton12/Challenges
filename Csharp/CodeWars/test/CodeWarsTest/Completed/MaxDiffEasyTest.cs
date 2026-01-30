using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class MaxDiffEasyTest
{
    [Test]
    public void SampleTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(MaxDiffEasy.MaxDiff([0, 1, 2, 3, 4, 5, 6]), Is.EqualTo(6));
            Assert.That(MaxDiffEasy.MaxDiff([-0, 1, 2, -3, 4, 5, -6]), Is.EqualTo(11));
            Assert.That(MaxDiffEasy.MaxDiff([0, 1, 2, 3, 4, 5, 16]), Is.EqualTo(16));
            Assert.That(MaxDiffEasy.MaxDiff([16]), Is.Zero);
            Assert.That(MaxDiffEasy.MaxDiff([]), Is.Zero);
        }
    }
}
