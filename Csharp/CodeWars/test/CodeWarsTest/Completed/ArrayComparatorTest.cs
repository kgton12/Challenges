using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class ArrayComparatorTest
{
    [Test, Description("Sample Tests")]
    public void SampleTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(ArrayComparator.MatchArrays([1, 2, 3, 4, 5], [2, 3, 4, 5, 6]), Is.EqualTo(4));
            Assert.That(ArrayComparator.MatchArrays([1, 2, 3, 4, 5], [5, 4]), Is.EqualTo(2));
            Assert.That(ArrayComparator.MatchArrays([0, -1, 1, 4], [-1]), Is.EqualTo(1));
        }
    }
}
