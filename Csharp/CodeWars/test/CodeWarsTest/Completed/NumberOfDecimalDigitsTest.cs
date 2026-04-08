using CodeWars.Completed;

namespace CodeWarsTest.Completed;

[TestFixture]
public class NumberOfDecimalDigitsTest
{
    [Test]
    public void Digits()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(NumberofDecimalDigits.Digits(5ul), Is.EqualTo(1));
            Assert.That(NumberofDecimalDigits.Digits(12345ul), Is.EqualTo(5));
            Assert.That(NumberofDecimalDigits.Digits(9876543210ul), Is.EqualTo(10));
        }
    }
}
