using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class CommonSubstringsTest
{
    [Test]
    public void ShouldBeTrue()
    {
        Assert.That(CommonSubstrings.SubstringTest("Something", "Home"), Is.True);
    }

    [Test]
    public void ShouldBeFalse()
    {
        Assert.That(CommonSubstrings.SubstringTest("Something", "Fun"), Is.False);
    }
}
