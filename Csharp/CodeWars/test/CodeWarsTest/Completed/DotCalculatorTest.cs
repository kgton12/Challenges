using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class DotCalculatorTest
{
    [Test]
    public void SampleTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(DotCalculator.Calculator("..... + ..............."), Is.EqualTo("...................."));
            Assert.That(DotCalculator.Calculator("..... - ..."), Is.EqualTo(".."));
            Assert.That(DotCalculator.Calculator("..... - ."), Is.EqualTo("...."));
            Assert.That(DotCalculator.Calculator("..... * ..."), Is.EqualTo("..............."));
            Assert.That(DotCalculator.Calculator("..... * .."), Is.EqualTo(".........."));
            Assert.That(DotCalculator.Calculator("..... // .."), Is.EqualTo(".."));
            Assert.That(DotCalculator.Calculator("..... // ."), Is.EqualTo("....."));
            Assert.That(DotCalculator.Calculator(". // .."), Is.EqualTo(""));
            Assert.That(DotCalculator.Calculator(". - ."), Is.EqualTo(""));
        }
    }
}
