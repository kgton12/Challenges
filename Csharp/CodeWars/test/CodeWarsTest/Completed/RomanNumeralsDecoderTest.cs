using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class RomanNumeralsDecoderTest
{
    [TestCase(1, "I")]
    public void Test1(int expected, string roman)
    {
        Assert.That(RomanNumeralsDecoder.Solution(roman), Is.EqualTo(expected));
    }

    [TestCase(2000, "MM")]
    public void Test2(int expected, string roman)
    {
        Assert.That(RomanNumeralsDecoder.Solution(roman), Is.EqualTo(expected));
    }

    [TestCase(1666, "MDCLXVI")]
    public void Test3(int expected, string roman)
    {
        Assert.That(RomanNumeralsDecoder.Solution(roman), Is.EqualTo(expected));
    }

    [TestCase(1000, "M")]
    public void Test4(int expected, string roman)
    {
        Assert.That(RomanNumeralsDecoder.Solution(roman), Is.EqualTo(expected));
    }

    [TestCase(400, "CD")]
    public void Test5(int expected, string roman)
    {
        Assert.That(RomanNumeralsDecoder.Solution(roman), Is.EqualTo(expected));
    }

    [TestCase(90, "XC")]
    public void Test6(int expected, string roman)
    {
        Assert.That(RomanNumeralsDecoder.Solution(roman), Is.EqualTo(expected));
    }

    [TestCase(40, "XL")]
    public void Test7(int expected, string roman)
    {
        Assert.That(RomanNumeralsDecoder.Solution(roman), Is.EqualTo(expected));
    }
}