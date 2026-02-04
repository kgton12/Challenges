using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class FindTheLuckyNumbersTest
{
    [Test]
    public void FixedTests()
    {
        Assert.That(FindTheLuckyNumbers.FilterLucky(new int[] { 1, 2, 3, 4, 5, 6, 7, 68, 69, 70, 15, 17 }), Is.EqualTo(new int[] { 7, 70, 17 }));
        Assert.That(FindTheLuckyNumbers.FilterLucky(new int[] { }), Is.EqualTo(new int[] { }));
    }
}
