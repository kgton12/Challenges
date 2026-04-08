using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class FindTheNthDigitOfANumberTest
{
    [Test]
    public void SampleTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(FindTheNthDigitOfaNumber.FindDigit(5673, 4), Is.EqualTo(5));
            Assert.That(FindTheNthDigitOfaNumber.FindDigit(129, 2), Is.EqualTo(2));
            Assert.That(FindTheNthDigitOfaNumber.FindDigit(-2825, 3), Is.EqualTo(8));
            Assert.That(FindTheNthDigitOfaNumber.FindDigit(-456, 4), Is.EqualTo(0));
            Assert.That(FindTheNthDigitOfaNumber.FindDigit(0, 20), Is.EqualTo(0));
            Assert.That(FindTheNthDigitOfaNumber.FindDigit(65, 0), Is.EqualTo(-1));
            Assert.That(FindTheNthDigitOfaNumber.FindDigit(24, -8), Is.EqualTo(-1));
        }
    }
}
