using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class Noobcode03CheckTheseLettersSeeIfLettersInString2ArePresentInString1Test
{
    [Test]
    public void BasicTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(Noobcode03CheckTheseLettersSeeIfLettersInString2ArePresentInString1.LetterCheck(["trances", "nectar"]), Is.True);
            Assert.That(Noobcode03CheckTheseLettersSeeIfLettersInString2ArePresentInString1.LetterCheck(["THE EYES", "they see"]), Is.True);
            Assert.That(Noobcode03CheckTheseLettersSeeIfLettersInString2ArePresentInString1.LetterCheck(["assert", "staring"]), Is.False);
            Assert.That(Noobcode03CheckTheseLettersSeeIfLettersInString2ArePresentInString1.LetterCheck(["arches", "later"]), Is.False);
            Assert.That(Noobcode03CheckTheseLettersSeeIfLettersInString2ArePresentInString1.LetterCheck(["dale", "caller"]), Is.False);
            Assert.That(Noobcode03CheckTheseLettersSeeIfLettersInString2ArePresentInString1.LetterCheck(["parses", "parsecs"]), Is.False);
            Assert.That(Noobcode03CheckTheseLettersSeeIfLettersInString2ArePresentInString1.LetterCheck(["replays", "adam"]), Is.False);
            Assert.That(Noobcode03CheckTheseLettersSeeIfLettersInString2ArePresentInString1.LetterCheck(["mastering", "streaming"]), Is.True);
            Assert.That(Noobcode03CheckTheseLettersSeeIfLettersInString2ArePresentInString1.LetterCheck(["drapes", "compadres"]), Is.False);
            Assert.That(Noobcode03CheckTheseLettersSeeIfLettersInString2ArePresentInString1.LetterCheck(["deltas", "slated"]), Is.True);
        }
    }
}
