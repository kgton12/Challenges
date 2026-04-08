using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class LogicalCalculatorTest
{
    [Test, Order(1)]
    public void BasicTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(LogicalCalculator.LogicalCalc([true, true, true, false], "AND"), Is.False);
            Assert.That(LogicalCalculator.LogicalCalc([true, true, true, false], "OR"), Is.True);
            Assert.That(LogicalCalculator.LogicalCalc([true, true, true, false], "XOR"), Is.True);
            Assert.That(LogicalCalculator.LogicalCalc([true, true, false, false], "AND"), Is.False);
            Assert.That(LogicalCalculator.LogicalCalc([true, true, false, false], "OR"), Is.True);
            Assert.That(LogicalCalculator.LogicalCalc([true, true, false, false], "XOR"), Is.False);
            Assert.That(LogicalCalculator.LogicalCalc([true, false, false, false], "AND"), Is.False);
            Assert.That(LogicalCalculator.LogicalCalc([true, false, false, false], "OR"), Is.True);
            Assert.That(LogicalCalculator.LogicalCalc([true, false, false, false], "XOR"), Is.True);
            Assert.That(LogicalCalculator.LogicalCalc([true, true], "AND"), Is.True);
            Assert.That(LogicalCalculator.LogicalCalc([true, true], "OR"), Is.True);
            Assert.That(LogicalCalculator.LogicalCalc([true, true], "XOR"), Is.False);
            Assert.That(LogicalCalculator.LogicalCalc([false, false], "AND"), Is.False);
            Assert.That(LogicalCalculator.LogicalCalc([false, false], "OR"), Is.False);
            Assert.That(LogicalCalculator.LogicalCalc([false, false], "XOR"), Is.False);
            Assert.That(LogicalCalculator.LogicalCalc([false], "AND"), Is.False);
            Assert.That(LogicalCalculator.LogicalCalc([false], "OR"), Is.False);
            Assert.That(LogicalCalculator.LogicalCalc([false], "XOR"), Is.False);
            Assert.That(LogicalCalculator.LogicalCalc([true], "AND"), Is.True);
            Assert.That(LogicalCalculator.LogicalCalc([true], "OR"), Is.True);
            Assert.That(LogicalCalculator.LogicalCalc([true], "XOR"), Is.True);
        }
    }
}
