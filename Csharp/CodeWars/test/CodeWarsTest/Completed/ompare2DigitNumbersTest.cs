using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class Compare2DigitNumbersTest
{
    [Test]
    public void Tests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(Compare2DigitNumbers.Compare(10, 11), Is.EqualTo("50%"));
            Assert.That(Compare2DigitNumbers.Compare(33, 33), Is.EqualTo("100%"));
            Assert.That(Compare2DigitNumbers.Compare(45, 45), Is.EqualTo("100%"));
            Assert.That(Compare2DigitNumbers.Compare(29, 92), Is.EqualTo("100%"));
            Assert.That(Compare2DigitNumbers.Compare(14, 24), Is.EqualTo("50%"));
            Assert.That(Compare2DigitNumbers.Compare(56, 57), Is.EqualTo("50%"));
            Assert.That(Compare2DigitNumbers.Compare(10, 22), Is.EqualTo("0%"));
            Assert.That(Compare2DigitNumbers.Compare(11, 44), Is.EqualTo("0%"));
            Assert.That(Compare2DigitNumbers.Compare(98, 70), Is.EqualTo("0%"));
            Assert.That(Compare2DigitNumbers.Compare(66, 16), Is.EqualTo("50%"));
            Assert.That(Compare2DigitNumbers.Compare(98, 88), Is.EqualTo("50%"));
            Assert.That(Compare2DigitNumbers.Compare(78, 58), Is.EqualTo("50%"));
            Assert.That(Compare2DigitNumbers.Compare(47, 56), Is.EqualTo("0%"));
        }
    }
}
