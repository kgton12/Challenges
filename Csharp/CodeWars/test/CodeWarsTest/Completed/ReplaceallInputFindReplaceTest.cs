using CodeWars.Completed;

namespace CodeWarsTest.Completed;

[TestFixture]
internal class ReplaceallInputFindReplaceTest
{
    [Test]
    public void BasicTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(ReplaceallInputFindReplace.ReplaceAll("string", "find", "replace"), Is.EqualTo("string"), "No matches found");
            Assert.That(ReplaceallInputFindReplace.ReplaceAll("string-string", "ing", "!"), Is.EqualTo("str!-str!"), "Matches found");
            Assert.That(ReplaceallInputFindReplace.ReplaceAll("", "", "string"), Is.EqualTo("string"), "Empty string as find");
            Assert.That(ReplaceallInputFindReplace.ReplaceAll("string", "", "-"), Is.EqualTo("-s-t-r-i-n-g-"), "Empty string as find");
            Assert.That(ReplaceallInputFindReplace.ReplaceAll("", "", "-"), Is.EqualTo("-"), "Empty input, empty find");
            Assert.That(ReplaceallInputFindReplace.ReplaceAll("1", "", "-"), Is.EqualTo("-1-"), "Single-character input, empty find");
            Assert.That(ReplaceallInputFindReplace.ReplaceAll("123", "", "-"), Is.EqualTo("-1-2-3-"), "Empty string as find");
            Assert.That(ReplaceallInputFindReplace.ReplaceAll("string", "string", "replaced"), Is.EqualTo("replaced"), "Original string as find");
            Assert.That(ReplaceallInputFindReplace.ReplaceAll("string", "trin", ""), Is.EqualTo("sg"), "Replace with empty string");
            Assert.That(ReplaceallInputFindReplace.ReplaceAll("s", "s", "ss"), Is.EqualTo("ss"), "Replace has find string included");
            Assert.That(ReplaceallInputFindReplace.ReplaceAll("123\\^$.|?*+()[]{}", "\\^$.|?*+()[]{}", "-"), Is.EqualTo("123-"), "$ replaced (regex gotcha)");
        }
    }
}