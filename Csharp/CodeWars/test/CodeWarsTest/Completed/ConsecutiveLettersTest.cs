using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class ConsecutiveLettersTest
{
    [Test]
    public void ExampleTests()
    {
        Assert.That(ConsecutiveLetters.Solve("abc"), Is.True);
        Assert.That(ConsecutiveLetters.Solve("abd"), Is.False);
        Assert.That(ConsecutiveLetters.Solve("dabc"), Is.True);
        Assert.That(ConsecutiveLetters.Solve("abbc"), Is.False);
    }
}
