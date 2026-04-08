using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class ReverseANumberTest
{
    [Test]
    public void _0_BasicTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(ReverseANumber.ReverseNumber(123), Is.EqualTo(321));
            Assert.That(ReverseANumber.ReverseNumber(-123), Is.EqualTo(-321));
            Assert.That(ReverseANumber.ReverseNumber(0), Is.Zero);
        }
    }
}
