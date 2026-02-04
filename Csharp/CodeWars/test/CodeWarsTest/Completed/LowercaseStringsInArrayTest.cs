using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class LowercaseStringsInArrayTest
{
    [Test]
    public void BasicTest()
    {
        Assert.That(LowercaseStringsInArray.ArrayLowerCase(new object[] { "Red", "Green" }), Is.EqualTo(new object[] { "red", "green" }));
    }
}
