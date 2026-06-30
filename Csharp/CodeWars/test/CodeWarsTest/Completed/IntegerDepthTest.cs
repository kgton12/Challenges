using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class IntegerDepthTest
{
    [Test, Order(1)]
    public void SampleTest1()
    {
        Assert.That(IntegerDepth.ComputeDepth(1), Is.EqualTo(10));
    }

    [Test, Order(2)]
    public void SampleTest2()
    {
        Assert.That(IntegerDepth.ComputeDepth(42), Is.EqualTo(9));
    }
}