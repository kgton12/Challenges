using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

[TestFixture]
public class FindTheOddIntTest
{
    [Test, Order(1)]
    public void Tests()
    {
        Assert.That(FindTheOddInt.FindIt([20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5]), Is.EqualTo(5));
    }
}
