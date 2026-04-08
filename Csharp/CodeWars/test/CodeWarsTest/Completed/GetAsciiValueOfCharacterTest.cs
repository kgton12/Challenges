using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class GetAsciiValueOfCharacterTest
{
    [Test]
    public void SampleTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(GetAsciiValueOfCharacter.GetASCII('A'), Is.EqualTo(65));
            Assert.That(GetAsciiValueOfCharacter.GetASCII(' '), Is.EqualTo(32));
            Assert.That(GetAsciiValueOfCharacter.GetASCII('!'), Is.EqualTo(33));
        }
    }
}
