using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class SumWithoutHighestAndLowestNumberTest
{
    [Test]
    public void SumPositives()
    {
        Assert.That(SumWithoutHighestAndLowestNumber.Sum([6, 2, 1, 8, 10]), Is.EqualTo(16));
    }
}
