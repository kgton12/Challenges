using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class ComfortableWordsTest
{
    [Test, Order(1)]
    public void ConfortableWords()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(ComfortableWords.ComfortableWord("yams"), Is.True, "yams is a confortable word");
            Assert.That(ComfortableWords.ComfortableWord("odor"), Is.True, "odor is a confortable word");
            Assert.That(ComfortableWords.ComfortableWord("their"), Is.True, "their is a confortable word");
        }
    }

    [Test, Order(2)]
    public void NotConfortableWords()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(ComfortableWords.ComfortableWord("leisure"), Is.False, "leisure is NOT a confortable word");
            Assert.That(ComfortableWords.ComfortableWord("touts"), Is.False, "touts is NOT a confortable word");
            Assert.That(ComfortableWords.ComfortableWord("test"), Is.False, "test is NOT a confortable word");
        }
    }
}
