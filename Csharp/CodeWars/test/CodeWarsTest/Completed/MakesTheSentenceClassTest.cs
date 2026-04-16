using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class MakesTheSentenceClassTest
{
    [Test]
    public void SampleTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(MakesTheSentenceClass.MakesTheSentence(['D', 'u', 'c', 'k', 's', 'q', 'u', 'a', 'c', 'k', '.'], "Ducks quack."), Is.True);
            Assert.That(MakesTheSentenceClass.MakesTheSentence(['S', 'h', 'e', 'a', 'd', 's', '.'], "She adds."), Is.False);
        }
    }
}
