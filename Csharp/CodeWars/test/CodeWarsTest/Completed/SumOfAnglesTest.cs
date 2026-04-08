using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class SumOfAnglesTest
{
    [Test]
    public void SampleTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(SumOfAngles.Angle(3), Is.EqualTo(180));
            Assert.That(SumOfAngles.Angle(4), Is.EqualTo(360));
        }
    }
}
