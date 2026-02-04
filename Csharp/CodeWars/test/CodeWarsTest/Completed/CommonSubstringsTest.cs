using CodeWars.Resolutions;

namespace CodeWarsTest;

public class CommonSubstringsTest
{
    [Test]
    public void ShouldBeTrue()
    {
        Assert.That(CommonSubstrings.SubstringTest("Something", "Home"), Is.True);
    }

    [Test, Order(2)]
    public void ShouldBeFalse()
    {
        Assert.That(CommonSubstrings.SubstringTest("Something", "Fun"), Is.False);
    }
}
