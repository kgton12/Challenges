using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class ExtractPortionOfFileNameTest
{
    [Test]
    public void ExampleTests()
    {
        Assert.That(ExtractPortionOfFileName.ExtractFileName("1_FILE_NAME.EXTENSION.OTHEREXTENSIONadasdassdassds34"), Is.EqualTo("FILE_NAME.EXTENSION"));
        Assert.That(ExtractPortionOfFileName.ExtractFileName("1231231223123131_FILE_NAME.EXTENSION.OTHEREXTENSION"), Is.EqualTo("FILE_NAME.EXTENSION"));
    }
}
