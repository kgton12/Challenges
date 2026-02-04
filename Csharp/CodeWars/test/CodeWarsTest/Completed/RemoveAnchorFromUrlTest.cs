using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class RemoveAnchorFromUrlTest
{
    [Test, Description("Sample Tests")]
    public void SampleTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(RemoveAnchorFromURL.RemoveUrlAnchor("www.codewars.com#about"), Is.EqualTo("www.codewars.com"));
            Assert.That(RemoveAnchorFromURL.RemoveUrlAnchor("www.codewars.com/katas/?page=1#about"), Is.EqualTo("www.codewars.com/katas/?page=1"));
            Assert.That(RemoveAnchorFromURL.RemoveUrlAnchor("www.codewars.com/katas/"), Is.EqualTo("www.codewars.com/katas/"));
        }
    }
}
