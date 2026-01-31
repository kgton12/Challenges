using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class MultiplyClassTest
{
    [Test]
    public void ShouldMultiple()
    {
        Assert.That(MultiplyClass.Multiply(2, 1), Is.EqualTo(2));
        Assert.That(MultiplyClass.Multiply(2, 4), Is.EqualTo(8));
    }
}
