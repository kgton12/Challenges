using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class BinaryToTextAsciiConversionTest
{
    [Test]
    public void Basic_Tests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(BinaryToTextAsciiConversion.BinaryToString(""), Is.EqualTo(""));
            Assert.That(BinaryToTextAsciiConversion.BinaryToString("0100100001100101011011000110110001101111"), Is.EqualTo("Hello"));
        }
    }
}
