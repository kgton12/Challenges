using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class UniqueInOrderClassTest
{
    [Test]
    public void EmptyTest()
    {
        Assert.That(UniqueInOrderClass.UniqueInOrder(""), Is.EqualTo(""));
    }
    [Test]
    public void Test1()
    {
        Assert.That(UniqueInOrderClass.UniqueInOrder("AAAABBBCCDAABBB"), Is.EqualTo("ABCDAB"));
    }
}
