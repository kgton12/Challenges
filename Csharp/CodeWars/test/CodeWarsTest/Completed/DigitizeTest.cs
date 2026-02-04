using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class DigitizeTest
{
    [Test]
    public void Test()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(DigitizeClass.Digitize(123), Is.EqualTo([1, 2, 3]));
            Assert.That(DigitizeClass.Digitize(1), Is.EqualTo([1]));
            Assert.That(DigitizeClass.Digitize(0), Is.EqualTo([0]));
            Assert.That(DigitizeClass.Digitize(1230), Is.EqualTo([1, 2, 3, 0]));
            Assert.That(DigitizeClass.Digitize(8675309), Is.EqualTo([8, 6, 7, 5, 3, 0, 9]));
        }
    }
}
