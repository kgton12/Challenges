using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class CatYearsDogYearsTest
{
    private static readonly int[] expectedOne = [1, 15, 15];
    private static readonly int[] expectedTwo = [2, 24, 24];
    private static readonly int[] expectedTen = [10, 56, 64];

    [Test, Order(1)]
    public void One()
    {
        Assert.That(CatYearsDogYears.HumanYearsCatYearsDogYears(1), Is.EqualTo(expectedOne));
    }

    [Test, Order(2)]
    public void Two()
    {
        Assert.That(CatYearsDogYears.HumanYearsCatYearsDogYears(2), Is.EqualTo(expectedTwo));
    }

    [Test, Order(3)]
    public void Ten()
    {
        Assert.That(CatYearsDogYears.HumanYearsCatYearsDogYears(10), Is.EqualTo(expectedTen));
    }
}
