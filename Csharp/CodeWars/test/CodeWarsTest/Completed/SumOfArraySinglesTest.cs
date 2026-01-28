using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class SumOfArraySinglesTest
{
    [Test, Order(1)]
    public void SampleTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(SumOfArraySingles.Repeats([4, 5, 7, 5, 4, 8]), Is.EqualTo(15));
            Assert.That(SumOfArraySingles.Repeats([9, 10, 19, 13, 19, 13]), Is.EqualTo(19));
            Assert.That(SumOfArraySingles.Repeats([16, 0, 11, 4, 8, 16, 0, 11]), Is.EqualTo(12));
            Assert.That(SumOfArraySingles.Repeats([5, 17, 18, 11, 13, 18, 11, 13]), Is.EqualTo(22));
            Assert.That(SumOfArraySingles.Repeats([5, 10, 19, 13, 10, 13]), Is.EqualTo(24));
        }
    }
}
