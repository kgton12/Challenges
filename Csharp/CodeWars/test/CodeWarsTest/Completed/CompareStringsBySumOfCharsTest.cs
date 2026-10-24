using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class CompareStringsBySumOfCharsTest
{
    [Test]
    public void Compare1()
    {
        Assert.That(CompareStringsBySumOfChars.Compare("AD", "BC"), Is.True);
    }

    [Test]
    public void Compare2()
    {
        Assert.That(CompareStringsBySumOfChars.Compare("AD", "DD"), Is.False);
    }
}
