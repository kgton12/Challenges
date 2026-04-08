using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class IntegerDifferenceTest
{
    [Test]
    public void BasicTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(IntegerDifference.IntDiff([1, 1, 5, 6, 9, 16, 27], 4), Is.EqualTo(3));
            Assert.That(IntegerDifference.IntDiff([1, 1, 3, 3], 2), Is.EqualTo(4));
        }
    }
}
