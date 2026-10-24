using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class MaximumSubarraySumTest
{
    [Test]
    public void Test0()
    {
        Assert.That(MaximumSubArraySum.MaxSequence([]), Is.Zero);
    }
    [Test]
    public void Test1()
    {
        Assert.That(MaximumSubArraySum.MaxSequence([-2, 1, -3, 4, -1, 2, 1, -5, 4]), Is.EqualTo(6));
    }
}
