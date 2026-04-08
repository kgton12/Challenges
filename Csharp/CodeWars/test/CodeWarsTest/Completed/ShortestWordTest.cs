using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class ShortestWordTest
{
    [Test]
    public void BasicTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(ShortestWord.FindShort("bitcoin take over the world maybe who knows perhaps"), Is.EqualTo(3));
            Assert.That(ShortestWord.FindShort("turns out random test cases are easier than writing out basic ones"), Is.EqualTo(3));
            Assert.That(ShortestWord.FindShort("Let's travel abroad shall we"), Is.EqualTo(2));
        }
    }
}
