using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class ParseFloatTest
{
    [Test]
    public void SampleTest()
    {
        Assert.That(ParseFloat.ParseF("1"), Is.EqualTo(1.0d));
    }
}
