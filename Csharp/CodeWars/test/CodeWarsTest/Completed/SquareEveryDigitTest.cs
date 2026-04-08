using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class SquareEveryDigitTest
{
    [Test]
    public void SquareDigitsTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(SquareEveryDigit.SquareDigits(9119), Is.EqualTo(811181), "Incorrect answer for n=9119");
            Assert.That(SquareEveryDigit.SquareDigits(0), Is.Zero, "Incorrect answer for n=0");
        }
    }
}
