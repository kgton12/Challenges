using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class MonotoneTravelTest
{
    [Test, Description("should work on increasing lists")]
    public void IncreasingTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(MonotoneTravel.IsMonotone(Enumerable.Range(1, 10).ToArray()), Is.True);
            Assert.That(MonotoneTravel.IsMonotone(Enumerable.Range(4, 9).ToArray()), Is.True);
        }
    }

    [Test, Description("should work on constant lists")]
    public void ConstantTest()
    {
        Assert.That(MonotoneTravel.IsMonotone([5, 5, 5, 5, 5]), Is.True);
    }

    [Test, Description("should work on an empty list")]
    public void EmptyTest()
    {
        Assert.That(MonotoneTravel.IsMonotone([]), Is.True);
    }

    [Test, Description("should return false on a decreasing list")]
    public void DecreasingTest()
    {
        Assert.That(MonotoneTravel.IsMonotone(Enumerable.Range(1, 5).Reverse().ToArray()), Is.False);
    }

    [Test, Description("should work on a non-decreasing list")]
    public void NonDecreasingTest()
    {
        Assert.That(MonotoneTravel.IsMonotone([1, 2, 3, 3, 4, 5]), Is.True);
    }
}
