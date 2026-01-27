using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class SplitStringsTest
{
    [Test]
    public void BasicTests()
    {
        var actual = SplitStrings.Solution("abc");
        Assert.That(actual, Is.EqualTo(["ab", "c_"]));

        actual = SplitStrings.Solution("abcdef");
        Assert.That(actual, Is.EqualTo(["ab", "cd", "ef"]));
    }
}
