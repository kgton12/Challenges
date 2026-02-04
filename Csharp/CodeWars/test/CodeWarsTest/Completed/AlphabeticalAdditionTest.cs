using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class AlphabeticalAdditionTest
{
    [Test, Order(1)]
    public void BasicTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(AlphabeticalAddition.AddLetters(['a', 'b', 'c']), Is.EqualTo('f'));
            Assert.That(AlphabeticalAddition.AddLetters(['z']), Is.EqualTo('z'));
            Assert.That(AlphabeticalAddition.AddLetters(['a', 'b']), Is.EqualTo('c'));
            Assert.That(AlphabeticalAddition.AddLetters(['c']), Is.EqualTo('c'));
            Assert.That(AlphabeticalAddition.AddLetters(['z', 'a']), Is.EqualTo('a'));
            Assert.That(AlphabeticalAddition.AddLetters(['y', 'c', 'b']), Is.EqualTo('d'));
            Assert.That(AlphabeticalAddition.AddLetters([]), Is.EqualTo('z'));
        }
    }
}
