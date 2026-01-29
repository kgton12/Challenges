using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class HowManyConsecutiveNumbersAreNeededTest
{
    [Test]
    public void BasicTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(HowManyConsecutiveNumbersAreNeeded.Consecutive([4, 8, 6]), Is.EqualTo(2));
            Assert.That(HowManyConsecutiveNumbersAreNeeded.Consecutive([1, 2, 3, 4]), Is.Zero);
            Assert.That(HowManyConsecutiveNumbersAreNeeded.Consecutive([]), Is.Zero);
            Assert.That(HowManyConsecutiveNumbersAreNeeded.Consecutive([1]), Is.Zero);
        }
    }
}
