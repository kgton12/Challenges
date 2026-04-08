using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class ReturnTheMissingElementTest
{
    [Test, Order(1)]
    public void EightIsMissing()
    {
        Assert.That(ReturnTheMissingElement.GetMissingElement([0, 5, 1, 3, 2, 9, 7, 6, 4]), Is.EqualTo(8));
    }

    [Test, Order(2)]
    public void ThreeIsMissing()
    {
        Assert.That(ReturnTheMissingElement.GetMissingElement([9, 2, 4, 5, 7, 0, 8, 6, 1]), Is.EqualTo(3));
    }
}
