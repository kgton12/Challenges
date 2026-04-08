using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class RgbToHexConversionTest
{
    [Test]
    [Order(1)]
    public void FixedTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(RgbToHexConversion.Rgb(255, 255, 255), Is.EqualTo("FFFFFF"));
            Assert.That(RgbToHexConversion.Rgb(255, 255, 300), Is.EqualTo("FFFFFF"));
            Assert.That(RgbToHexConversion.Rgb(0, 0, 0), Is.EqualTo("000000"));
            Assert.That(RgbToHexConversion.Rgb(148, 0, 211), Is.EqualTo("9400D3"));
            Assert.That(RgbToHexConversion.Rgb(148, -20, 211), Is.EqualTo("9400D3"), "Handle negative numbers.");
            Assert.That(RgbToHexConversion.Rgb(144, 195, 212), Is.EqualTo("90C3D4"));
            Assert.That(RgbToHexConversion.Rgb(212, 53, 12), Is.EqualTo("D4350C"), "Consider single hex digit numbers.");
        }
    }
}
