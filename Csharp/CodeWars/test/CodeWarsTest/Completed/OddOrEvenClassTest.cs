using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class OddOrEvenClassTest
{
    [Test, Description("Edge tests")]
    public void EdgeTests()
    {
        var actual = OddOrEvenClass.OddOrEven([0]);
        Assert.That(actual, Is.EqualTo("even"));
        actual = OddOrEvenClass.OddOrEven([1]);
        Assert.That(actual, Is.EqualTo("odd"));
        actual = OddOrEvenClass.OddOrEven([]);
        Assert.That(actual, Is.EqualTo("even"));
    }

    [Test, Description("Even tests")]
    public void EvenTests()
    {
        var actual = OddOrEvenClass.OddOrEven([0, 1, 5]);
        Assert.That(actual, Is.EqualTo("even"));
        actual = OddOrEvenClass.OddOrEven([0, 1, 3]);
        Assert.That(actual, Is.EqualTo("even"));
        actual = OddOrEvenClass.OddOrEven([1023, 1, 2]);
        Assert.That(actual, Is.EqualTo("even"));
    }

    [Test, Description("Negative Even tests")]
    public void NegativeEvenTests()
    {
        var actual = OddOrEvenClass.OddOrEven([0, -1, -5]);
        Assert.That(actual, Is.EqualTo("even"));
        actual = OddOrEvenClass.OddOrEven([0, -1, -3]);
        Assert.That(actual, Is.EqualTo("even"));
        actual = OddOrEvenClass.OddOrEven([-1023, 1, -2]);
        Assert.That(actual, Is.EqualTo("even"));
    }

    [Test, Description("Odd tests")]
    public void OddTests()
    {
        var actual = OddOrEvenClass.OddOrEven([0, 1, 2]);
        Assert.That(actual, Is.EqualTo("odd"));
        actual = OddOrEvenClass.OddOrEven([0, 1, 4]);
        Assert.That(actual, Is.EqualTo("odd"));
        actual = OddOrEvenClass.OddOrEven([1023, 1, 3]);
        Assert.That(actual, Is.EqualTo("odd"));
    }

    [Test, Description("Negative Odd tests")]
    public void NegativeOddTests()
    {
        var actual = OddOrEvenClass.OddOrEven([0, -1, 2]);
        Assert.That(actual, Is.EqualTo("odd"));
        actual = OddOrEvenClass.OddOrEven([0, 1, -4]);
        Assert.That(actual, Is.EqualTo("odd"));
        actual = OddOrEvenClass.OddOrEven([-1023, -1, 3]);
        Assert.That(actual, Is.EqualTo("odd"));
    }
}
