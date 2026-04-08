using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class LastDigitsOfANumberTest
{
    [Test]
    public void SampleTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(LastDigitsOfANumber.LastDigit(1, 1), Is.EqualTo([1]));
            Assert.That(LastDigitsOfANumber.LastDigit(123767, 4), Is.EqualTo([3, 7, 6, 7]));
            Assert.That(LastDigitsOfANumber.LastDigit(0, 1), Is.EqualTo([0]));
            Assert.That(LastDigitsOfANumber.LastDigit(34625647867585, 10), Is.EqualTo([5, 6, 4, 7, 8, 6, 7, 5, 8, 5]));
            Assert.That(LastDigitsOfANumber.LastDigit(1234, 0), Is.EqualTo(new int[] { }));
            Assert.That(LastDigitsOfANumber.LastDigit(24134, -4), Is.EqualTo(new int[] { }));
            Assert.That(LastDigitsOfANumber.LastDigit(1343, 5), Is.EqualTo([1, 3, 4, 3]));
        }
    }
}
