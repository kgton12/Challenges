using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class FindTheLuckyNumbersTest
{
    [Test]
    public void FixedTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(FindTheLuckyNumbers.FilterLucky([1, 2, 3, 4, 5, 6, 7, 68, 69, 70, 15, 17]), Is.EqualTo([7, 70, 17]));
            Assert.That(FindTheLuckyNumbers.FilterLucky([]), Is.EqualTo(new int[] { }));
        }
    }
}
