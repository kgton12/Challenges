using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class SimpleFun79DeleteADigitTest
{
    [Test]
    public void When152_Then52()
    {
        Assert.That(SimpleFun79DeleteADigit.DeleteDigit(152), Is.EqualTo(52));
    }

    [Test]
    public void When01001_Then101()
    {
        Assert.That(SimpleFun79DeleteADigit.DeleteDigit(1001), Is.EqualTo(101));
    }

    [Test]
    public void When10_Then1()
    {
        Assert.That(SimpleFun79DeleteADigit.DeleteDigit(10), Is.EqualTo(1));
    }
}
