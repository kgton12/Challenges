using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class CompleteThePattern1Test
{
    [Test]
    public void SimpleNumbers()
    {
        Assert.That(CompleteThePattern1.Pattern(1), Is.EqualTo("1"));
        Assert.That(CompleteThePattern1.Pattern(2), Is.EqualTo("1\n22"));
        Assert.That(CompleteThePattern1.Pattern(5), Is.EqualTo("1\n22\n333\n4444\n55555"));
    }
}
