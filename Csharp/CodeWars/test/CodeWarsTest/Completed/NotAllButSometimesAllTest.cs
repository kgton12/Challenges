using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class NotAllButSometimesAllTest
{
    [Test]
    public void BasicTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(NotAllButSometimesAll.Remove("this is a string", new Dictionary<char, int> { { 't', 1 }, { 'i', 2 } }), Is.EqualTo("hs s a string"));
            Assert.That(NotAllButSometimesAll.Remove("hello world", new Dictionary<char, int> { { 'x', 5 }, { 'i', 2 } }), Is.EqualTo("hello world"));
            Assert.That(NotAllButSometimesAll.Remove("apples and bananas", new Dictionary<char, int> { { 'a', 50 }, { 'n', 1 } }), Is.EqualTo("pples d bnns"));
            Assert.That(NotAllButSometimesAll.Remove("a", new Dictionary<char, int> { { 'a', 1 }, { 'n', 1 } }), Is.EqualTo(""));
            Assert.That(NotAllButSometimesAll.Remove("codewars", new Dictionary<char, int> { { 'c', 5 }, { 'o', 1 }, { 'd', 1 }, { 'e', 1 }, { 'w', 1 }, { 'z', 1 }, { 'a', 1 }, { 'r', 1 }, { 's', 1 } }), Is.EqualTo(""));
        }
    }
}
