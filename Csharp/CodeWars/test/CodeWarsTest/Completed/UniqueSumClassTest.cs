using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class UniqueSumClassTest
{
    [Test]
    public void Test1()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(UniqueSumClass.UniqueSum([1, 2, 3]), Is.EqualTo(6));
            Assert.That(UniqueSumClass.UniqueSum([1, 3, 8, 1, 8]), Is.EqualTo(12));
            Assert.That(UniqueSumClass.UniqueSum([-1, -1, 5, 2, -7]), Is.EqualTo(-1));
        }
    }
}
