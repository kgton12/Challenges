using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class CompareStringsBySumOfCharsTest
{
    [Test, Order(1)]
    public void Compare1()
    {
        Assert.That(CompareStringsBySumOfChars.Compare("AD", "BC"), Is.True);
    }

    [Test, Order(2)]
    public void Compare2()
    {
        Assert.That(CompareStringsBySumOfChars.Compare("AD", "DD"), Is.False);
    }
}
