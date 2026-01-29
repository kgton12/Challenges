using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class CountOfPositivesSumOfNegativesTest
{
    [Test, Order(1)]
    public void CountPositivesSumNegatives_BasicTest()
    {
        int[] expectedResult = [10, -65];

        Assert.That(CountOfPositivesSumOfNegatives.CountPositivesSumNegatives([1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15]), Is.EqualTo(expectedResult));
    }

    [Test, Order(2)]
    public void CountPositivesSumNegatives_InputWithZeroes()
    {
        int[] expectedResult = [8, -50];

        Assert.That(CountOfPositivesSumOfNegatives.CountPositivesSumNegatives([0, 2, 3, 0, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14]), Is.EqualTo(expectedResult));
    }

    [Test, Order(3)]
    public void CountPositivesSumNegatives_InputNull()
    {
        int[] expectedResult = [];

        Assert.That(CountOfPositivesSumOfNegatives.CountPositivesSumNegatives(null), Is.EqualTo(expectedResult));
    }

    [Test, Order(4)]
    public void CountPositivesSumNegatives_InputEmpty()
    {
        int[] expectedResult = [];

        Assert.That(CountOfPositivesSumOfNegatives.CountPositivesSumNegatives([]), Is.EqualTo(expectedResult));
    }
}
