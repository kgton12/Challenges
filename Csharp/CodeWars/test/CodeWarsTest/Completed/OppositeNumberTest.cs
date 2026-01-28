using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class OppositeNumberTest
{
    [Test]
    public void Test1()
    {
        Assert.That(OppositeNumber.Opposite(1), Is.EqualTo(-1), "Incorrect answer for number=1");
    }
}
