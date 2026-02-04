using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class StringReverseSlicing101Test
{
    [Test]
    public void FixedTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(StringReverseSlicing101.ReverseSlice("123"), Is.EqualTo(["321", "21", "1"]));
            Assert.That(StringReverseSlicing101.ReverseSlice("abcde"), Is.EqualTo(["edcba", "dcba", "cba", "ba", "a"]));
        }
    }
}
