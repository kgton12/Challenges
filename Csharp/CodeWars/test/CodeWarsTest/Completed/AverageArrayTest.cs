using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class AverageArrayTest
{
    [Test]
    public void SampleTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(AverageArray.AvgArray([[1, 2, 3, 4], [5, 6, 7, 8]]), Is.EqualTo([3, 4, 5, 6]));
            Assert.That(AverageArray.AvgArray([[2, 3, 9, 10, 7], [12, 6, 89, 45, 3], [9, 12, 56, 10, 34], [67, 23, 1, 88, 34]]), Is.EqualTo([22.5, 11, 38.75, 38.25, 19.5]));
        }
    }
}
