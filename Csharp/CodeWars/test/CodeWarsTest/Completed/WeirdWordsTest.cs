using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class WeirdWordsTest
{
    [Test]
    public void BasicTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(WeirdWords.NextLetter("My Name Is Zoo"), Is.EqualTo("Nz Obnf Jt App"));
            Assert.That(WeirdWords.NextLetter("What is your name"), Is.EqualTo("Xibu jt zpvs obnf"));
            Assert.That(WeirdWords.NextLetter("zOo"), Is.EqualTo("aPp"));
        }
    }
}
