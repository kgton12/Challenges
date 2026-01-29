using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class MaximumSubarraySumTest
{
    [Test, Order(1)]
    public void Test0()
    {
        Assert.That(MaximumSubArraySum.MaxSequence([]), Is.Zero);
    }
    [Test, Order(2)]
    public void Test1()
    {
        Assert.That(MaximumSubArraySum.MaxSequence([-2, 1, -3, 4, -1, 2, 1, -5, 4]), Is.EqualTo(6));
    }
}
