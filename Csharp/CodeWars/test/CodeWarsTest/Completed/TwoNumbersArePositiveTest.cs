using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class TwoNumbersArePositiveTest
{
    [Test]
    public void BasicTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(TwoNumbersArePositive.TwoArePositive(2, 4, -3), Is.True, "(2, 4, -3)");
            Assert.That(TwoNumbersArePositive.TwoArePositive(-4, 6, 8), Is.True, "(-4, 6, 8)");
            Assert.That(TwoNumbersArePositive.TwoArePositive(4, -6, 9), Is.True, "(4, -6, 9)");
            Assert.That(TwoNumbersArePositive.TwoArePositive(4, 6, 0), Is.True, "(4, 6, 0)");
            Assert.That(TwoNumbersArePositive.TwoArePositive(-4, 6, 0), Is.False, "(-4, 6, 0)");
            Assert.That(TwoNumbersArePositive.TwoArePositive(4, 6, 10), Is.False, "(4, 6, 10)");
            Assert.That(TwoNumbersArePositive.TwoArePositive(-14, -3, -4), Is.False, "(-14, -3, -4)");
        }
    }
}
