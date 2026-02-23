using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class KatastropheTest
{
    [Test]
    public void SampleTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(Katastrophe.StrongEnough([[2, 3, 1], [3, 1, 1,], [1, 1, 2]], 2), Is.EqualTo("Safe!"));
            Assert.That(Katastrophe.StrongEnough([[5, 8, 7], [3, 3, 1,], [4, 1, 2]], 2), Is.EqualTo("Safe!"));
            Assert.That(Katastrophe.StrongEnough([[5, 8, 7], [3, 3, 1,], [4, 1, 2]], 3), Is.EqualTo("Needs Reinforcement!"));
        }
    }
}
