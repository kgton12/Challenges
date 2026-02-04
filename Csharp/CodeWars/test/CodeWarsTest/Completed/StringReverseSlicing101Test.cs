using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class StringReverseSlicing101Test
{
    [Test]
    public void FixedTest()
    {
        Assert.That(StringReverseSlicing101.ReverseSlice("123"), Is.EqualTo(new string[] { "321", "21", "1" }));
        Assert.That(StringReverseSlicing101.ReverseSlice("abcde"), Is.EqualTo(new string[] { "edcba", "dcba", "cba", "ba", "a" }));
    }
}
