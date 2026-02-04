using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class PandemiaTest
{
    readonly double tolerance = 0.00000000001;
    [Test]
    public void Test1()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(Pandemia.Infected("01000000X000X011X0X"), Is.EqualTo(73.33333333333333).Within(tolerance));
            Assert.That(Pandemia.Infected("01X000X010X011XX"), Is.EqualTo(72.72727272727273).Within(tolerance));
            Assert.That(Pandemia.Infected("XXXXX"), Is.EqualTo(0).Within(tolerance));
            Assert.That(Pandemia.Infected("0000000010"), Is.EqualTo(100).Within(tolerance));
            Assert.That(Pandemia.Infected("X00X000000X10X0100"), Is.EqualTo(42.857142857142854).Within(tolerance));
        }
    }
}
