using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class PartialWordSearchingTest
{
    [Test, Order(1)]
    public void BasicTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(PartialWordSearching.WordSearch("ab", ["za", "ab", "abc", "zab", "zbc"]), Is.EqualTo(["ab", "abc", "zab"]));
            Assert.That(PartialWordSearching.WordSearch("aB", ["za", "ab", "abc", "zab", "zbc"]), Is.EqualTo(["ab", "abc", "zab"]));
            Assert.That(PartialWordSearching.WordSearch("ab", ["za", "aB", "Abc", "zAB", "zbc"]), Is.EqualTo(["aB", "Abc", "zAB"]));
            Assert.That(PartialWordSearching.WordSearch("abcd", ["za", "aB", "Abc", "zAB", "zbc"]), Is.EqualTo(["Empty"]));
        }
    }
}
