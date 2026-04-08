using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class ToLeetSpeakClassTest
{
    [Test]
    public void BasicTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(ToLeetSpeakClass.ToLeetSpeak("LEET"), Is.EqualTo("1337"));
            Assert.That(ToLeetSpeakClass.ToLeetSpeak("CODEWARS"), Is.EqualTo("(0D3W@R$"));
            Assert.That(ToLeetSpeakClass.ToLeetSpeak("HELLO WORLD"), Is.EqualTo("#3110 W0R1D"));
            Assert.That(ToLeetSpeakClass.ToLeetSpeak("LOREM IPSUM DOLOR SIT AMET"), Is.EqualTo("10R3M !P$UM D010R $!7 @M37"));
            Assert.That(ToLeetSpeakClass.ToLeetSpeak("THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG"), Is.EqualTo("7#3 QU!(K 8R0WN F0X JUMP$ 0V3R 7#3 1@2Y D06"));
        }
    }
}
