using CodeWars.Resolutions;

namespace CodeWarsTest;

public class HowManyArgumentsTest
{
    [Test]
    public void SampleTest()
    {
        Assert.That(HowManyArguments.CountArgs(1, 2, 3), Is.EqualTo(3));
        Assert.That(HowManyArguments.CountArgs(1, 2, "uhsaf uas"), Is.EqualTo(3));
        Assert.That(HowManyArguments.CountArgs(1), Is.EqualTo(1));
        Assert.That(HowManyArguments.CountArgs('a', 865, "asfhgajsf", new object[] { "dawdjio", null, new List<object>() }), Is.EqualTo(4));
        Assert.That(HowManyArguments.CountArgs(), Is.Zero);
    }
}
