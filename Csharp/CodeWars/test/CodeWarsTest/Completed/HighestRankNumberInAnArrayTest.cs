using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class HighestRankNumberInAnArrayTest
{
    [Test]
    public void BasicTest()
    {
        var arr = new int[] { 12, 10, 8, 12, 7, 6, 4, 10, 12 };
        Assert.That(HighestRankNumberInAnArray.HighestRank(arr), Is.EqualTo(12));
    }
}
