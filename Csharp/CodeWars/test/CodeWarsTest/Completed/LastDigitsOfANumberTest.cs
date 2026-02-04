using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class LastDigitsOfANumberTest
{
    [Test]
    public void SampleTest()
    {
        Assert.That(LastDigitsOfANumber.LastDigit(1, 1), Is.EqualTo(new[] { 1 }));
        Assert.That(LastDigitsOfANumber.LastDigit(123767, 4), Is.EqualTo(new[] { 3, 7, 6, 7 }));
        Assert.That(LastDigitsOfANumber.LastDigit(0, 1), Is.EqualTo(new[] { 0 }));
        Assert.That(LastDigitsOfANumber.LastDigit(34625647867585, 10), Is.EqualTo(new[] { 5, 6, 4, 7, 8, 6, 7, 5, 8, 5 }));
        Assert.That(LastDigitsOfANumber.LastDigit(1234, 0), Is.EqualTo(new int[] { }));
        Assert.That(LastDigitsOfANumber.LastDigit(24134, -4), Is.EqualTo(new int[] { }));
        Assert.That(LastDigitsOfANumber.LastDigit(1343, 5), Is.EqualTo(new[] { 1, 3, 4, 3 }));
    }
}
