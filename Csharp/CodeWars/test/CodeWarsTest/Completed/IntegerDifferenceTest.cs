using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class IntegerDifferenceTest
{
    [Test]
    public void BasicTests()
    {
        Assert.That(IntegerDifference.IntDiff(new int[] { 1, 1, 5, 6, 9, 16, 27 }, 4), Is.EqualTo(3));
        Assert.That(IntegerDifference.IntDiff(new int[] { 1, 1, 3, 3 }, 2), Is.EqualTo(4));
    }
}
