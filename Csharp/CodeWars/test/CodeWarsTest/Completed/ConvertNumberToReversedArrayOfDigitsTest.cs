using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class ConvertNumberToReversedArrayOfDigitsTest
{
    [Test]
    public void MyTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(ConvertNumberToReversedArrayOfDigits.Digitize(35231), Is.EqualTo([1, 3, 2, 5, 3]));
            Assert.That(ConvertNumberToReversedArrayOfDigits.Digitize(0), Is.EqualTo([0]));
        }
    }
}
