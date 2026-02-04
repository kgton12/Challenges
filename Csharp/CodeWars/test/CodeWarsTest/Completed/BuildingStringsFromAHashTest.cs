using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class BuildingStringsFromAHashTest
{
    [Test, Description("Basic Tests")]
    public void Test()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(BuildingStringsFromAHash.StringifyDict(new Dictionary<char, int> { { 'a', 1 }, { 'b', 2 } }), Is.EqualTo("a = 1,b = 2"));
            Assert.That(BuildingStringsFromAHash.StringifyDict(new Dictionary<char, int> { { 'b', 1 }, { 'c', 2 }, { 'e', 3 } }), Is.EqualTo("b = 1,c = 2,e = 3"));
            Assert.That(BuildingStringsFromAHash.StringifyDict(new Dictionary<char, int>()), Is.EqualTo(""));
        }
    }
}
