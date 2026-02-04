using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class ReplaceEveryNthTest
{
    [Test]
    public void BasicTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(ReplaceEveryNth.ReplaceNth("Vader said: No, I am your father!", 2, 'a', 'o'), Is.EqualTo("Vader soid: No, I am your fother!"));
            Assert.That(ReplaceEveryNth.ReplaceNth("Vader said: No, I am your father!", 4, 'a', 'o'), Is.EqualTo("Vader said: No, I am your fother!"));
            Assert.That(ReplaceEveryNth.ReplaceNth("Vader said: No, I am your father!", 6, 'a', 'o'), Is.EqualTo("Vader said: No, I am your father!"));
            Assert.That(ReplaceEveryNth.ReplaceNth("Vader said: No, I am your father!", 0, 'a', 'o'), Is.EqualTo("Vader said: No, I am your father!"));
            Assert.That(ReplaceEveryNth.ReplaceNth("Vader said: No, I am your father!", -2, 'a', 'o'), Is.EqualTo("Vader said: No, I am your father!"));
            Assert.That(ReplaceEveryNth.ReplaceNth("Vader said: No, I am your father!", 1, 'i', 'y'), Is.EqualTo("Vader sayd: No, I am your father!"));
            Assert.That(ReplaceEveryNth.ReplaceNth("Luke cries: Noooooooooooooooo!", 6, 'o', 'i'), Is.EqualTo("Luke cries: Noooooioooooioooo!"));
        }
    }
}
