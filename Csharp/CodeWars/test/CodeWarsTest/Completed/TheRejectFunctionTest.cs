using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class TheRejectFunctionTest
{
    [Test, Description("Sample Test")]
    public void SampleTest()
    {
        Assert.That(TheRejectFunction.Reject([1, 2, 3, 4, 5, 6], (n) => n % 2 == 0), Is.EqualTo([1, 3, 5]));
    }
}
