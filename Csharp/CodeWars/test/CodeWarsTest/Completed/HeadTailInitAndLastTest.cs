using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class HeadTailInitAndLastTest
{
    [Test, Description("Sample Tests")]
    public void SampleTest()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(new List<int> { 5, 1 }.Head(), Is.EqualTo(5));
            Assert.That(new List<int> { 1, 2, 3 }.Tail(), Is.EqualTo(new List<int> { 2, 3 }));
            Assert.That(new List<int> { 1, 5, 7, 9 }.Init(), Is.EqualTo(new List<int> { 1, 5, 7 }));
            Assert.That(new List<int> { 7, 2 }.Last_(), Is.EqualTo(2));
        }
    }
}
