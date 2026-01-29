using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class DetectPangramTest
{
    [Test]
    public void SampleTests()
    {
        Assert.That(DetectPangram.IsPangram("The quick brown fox jumps over the lazy dog."), Is.True);
    }
}
