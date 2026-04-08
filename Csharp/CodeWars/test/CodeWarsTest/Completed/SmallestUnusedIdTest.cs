using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class SmallestUnusedIdTest
{
    [Test]
    [TestCase(new int[] { 0, 1, 2, 3, 5 }, ExpectedResult = 4)]
    [TestCase(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, ExpectedResult = 11)]
    [TestCase(new int[] { 9, 9, 8 }, ExpectedResult = 0)]
    public static int FixedTest(int[] ids)
    {
        return SmallestUnusedId.NextId(ids);
    }
}
