using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class DeleteOccurrencesOfAnElementIfItOccursMoreThanNTimesTest
{
    [Test]
    [Order(1)]
    public void TestSimple()
    {
        var expected = new int[] { 20, 37, 21 };

        var actual = DeleteOccurrencesOfAnElementIfItOccursMoreThanNTimes.DeleteNth([20, 37, 20, 21], 1);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    [Order(2)]
    public void TestSimple2()
    {
        var expected = new int[] { 1, 1, 3, 3, 7, 2, 2, 2 };

        var actual = DeleteOccurrencesOfAnElementIfItOccursMoreThanNTimes.DeleteNth([1, 1, 3, 3, 7, 2, 2, 2, 2], 3);

        Assert.That(actual, Is.EqualTo(expected));
    }
}
