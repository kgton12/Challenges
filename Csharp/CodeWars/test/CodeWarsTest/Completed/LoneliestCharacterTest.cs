using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class LoneliestCharacterTest
{
    [Test]
    public void MyTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(LoneliestCharacter.Loneliest("a"), Is.EqualTo(['a']));
            Assert.That(LoneliestCharacter.Loneliest("abc d   ef  g   h i j      "), Is.EqualTo(['g']));
            Assert.That(LoneliestCharacter.Loneliest("a   b   c"), Is.EqualTo(['b']));
            Assert.That(LoneliestCharacter.Loneliest("  abc  d  z    f gk s "), Is.EqualTo(['z']));
            Assert.That(LoneliestCharacter.Loneliest("a  b  c  de  ").OrderBy(x => x).ToArray(), Is.EqualTo(['b', 'c']));
            Assert.That(LoneliestCharacter.Loneliest("abc").OrderBy(x => x).ToArray(), Is.EqualTo(['a', 'b', 'c']));
        }
    }
}
