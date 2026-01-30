using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class DnaToRnaConversionTest
{
    [Test]
    public void Test()
    {
        Assert.That(DNAToRNAConversion.DnaToRna("TTTT"), Is.EqualTo("UUUU"));
    }
}
