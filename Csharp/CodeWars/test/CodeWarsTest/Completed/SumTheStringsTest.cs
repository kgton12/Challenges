using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class SumTheStringsTest
{
    [Test(Description = "Tests")]
    public void Tests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(SumTheStrings.StringsSum("4", "5"), Is.EqualTo("9"));
            Assert.That(SumTheStrings.StringsSum("34", "5"), Is.EqualTo("39"));
            Assert.That(SumTheStrings.StringsSum("", "9"), Is.EqualTo("9"));
            Assert.That(SumTheStrings.StringsSum("9", ""), Is.EqualTo("9"));
            Assert.That(SumTheStrings.StringsSum("", ""), Is.EqualTo("0"));
        }
    }
}
