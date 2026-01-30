using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class SimpleCalculatorTest
{
    [Test, Description("should calculate the result of valid inputs"), Order(1)]
    public void Test()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(SimpleCalculator.Calculator(6, 2, '+'), Is.EqualTo(8));
            Assert.That(SimpleCalculator.Calculator(4, 3, '-'), Is.EqualTo(1));
            Assert.That(SimpleCalculator.Calculator(5, 5, '*'), Is.EqualTo(25));
            Assert.That(SimpleCalculator.Calculator(5, 4, '/'), Is.EqualTo(1.25));
        }
    }

    [Test, Description("should throw ArgumentException with invalid inputs"), Order(2)]
    public void ErrorTest()
    {
        Assert.That(() => SimpleCalculator.Calculator(6, 2, '&'), Throws.ArgumentException);
    }
}
