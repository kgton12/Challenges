using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class SortArrays1Test
{
    [Test]
    public void BasicTests()
    {
        Assert.That(string.Join(",", SortArrays1.SortMe(new[] { "one", "two", "three" })), Is.EqualTo("one,three,two"));
    }
}
