using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class IntegerDepthTest
{
    [Test]
    public void SampleTest1()
    {
        Assert.That(IntegerDepth.ComputeDepth(1), Is.EqualTo(10));
    }

    [Test]
    public void SampleTest2()
    {
        Assert.That(IntegerDepth.ComputeDepth(42), Is.EqualTo(9));
    }
}