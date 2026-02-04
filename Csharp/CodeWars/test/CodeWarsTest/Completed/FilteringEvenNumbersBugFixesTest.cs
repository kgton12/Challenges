using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class FilteringEvenNumbersBugFixesTest
{
    [Test, Order(1)]
    public void FirstTest()
    {
        List<int> listOfNumbers = [1, 2, 2, 2, 4, 3, 4, 5, 6, 7];
        List<int> expectedResult = [1, 3, 5, 7];
        Assert.That(FilteringEvenNumbersBugFixes.FilterOddNumber(listOfNumbers), Is.EqualTo(expectedResult));
    }

    [Test, Order(2)]
    public void SecondTest()
    {
        List<int> listOfNumbers = [1, 2, 2, 2, 4, 3, 4];
        List<int> expectedResult = [1, 3];
        Assert.That(FilteringEvenNumbersBugFixes.FilterOddNumber(listOfNumbers), Is.EqualTo(expectedResult));
    }
}
