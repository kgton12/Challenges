using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class MaxminArraysTest
{
    [Test]
    public void SampleTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(MaxminArrays.Solve([15, 11, 10, 7, 12]), Is.EqualTo(new List<int> { 15, 7, 12, 10, 11 }));
            Assert.That(MaxminArrays.Solve([91, 75, 86, 14, 82]), Is.EqualTo(new List<int> { 91, 14, 86, 75, 82 }));
            Assert.That(MaxminArrays.Solve([84, 79, 76, 61, 78]), Is.EqualTo(new List<int> { 84, 61, 79, 76, 78 }));
            Assert.That(MaxminArrays.Solve([52, 77, 72, 44, 74, 76, 40]), Is.EqualTo(new List<int> { 77, 40, 76, 44, 74, 52, 72 }));
            Assert.That(MaxminArrays.Solve([1, 6, 9, 4, 3, 7, 8, 2]), Is.EqualTo(new List<int> { 9, 1, 8, 2, 7, 3, 6, 4 }));
            Assert.That(MaxminArrays.Solve([78, 79, 52, 87, 16, 74, 31, 63, 80]), Is.EqualTo(new List<int> { 87, 16, 80, 31, 79, 52, 78, 63, 74 }));
        }
    }
}
