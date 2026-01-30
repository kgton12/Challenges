using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class ThirdAngleOfATriangleTest
{
    [Test]
    public void SampleTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(ThirdAngleOfATriangle.OtherAngle(30, 60), Is.EqualTo(90));
            Assert.That(ThirdAngleOfATriangle.OtherAngle(60, 60), Is.EqualTo(60));
            Assert.That(ThirdAngleOfATriangle.OtherAngle(43, 78), Is.EqualTo(59));
            Assert.That(ThirdAngleOfATriangle.OtherAngle(10, 20), Is.EqualTo(150));
        }
    }
}
