using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class DecodeTheMorseCodeTest
{
    [Test]
    public void MorseCodeDecoderBasicTest_1()
    {
        string input = ".... . -.--   .--- ..- -.. .";
        string expected = "HEY JUDE";

        string actual = DecodeTheMorseCode.Decode(input);

        Assert.That(actual, Is.EqualTo(expected));
    }
}
