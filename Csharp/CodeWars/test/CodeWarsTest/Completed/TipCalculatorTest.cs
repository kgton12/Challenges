using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class TipCalculatorTest
{
    [Test, Description("Sample Tests")]
    public void SampleTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(TipCalculator.CalculateTip(20, "Excellent"), Is.EqualTo(4));
            Assert.That(TipCalculator.CalculateTip(26.95, "good"), Is.EqualTo(3));
        }
    }
}
