using CodeWars.Resolutions;

namespace CodeWarsTest;

public class InsertDashesTest
{
    [Test]
    public void SampleTest()
    {
        Assert.That(InsertDashes.InsertDash(454793), Is.EqualTo("4547-9-3"));
        Assert.That(InsertDashes.InsertDash(123456), Is.EqualTo("123456"));
        Assert.That(InsertDashes.InsertDash(1003567), Is.EqualTo("1003-567"));
    }
}
