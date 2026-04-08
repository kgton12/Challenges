using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class UniqueInOrderClassTest
{
    [Test]
    [Order(1)]
    public void EmptyTest()
    {
        Assert.That(UniqueInOrderClass.UniqueInOrder(""), Is.EqualTo(""));
    }
    [Test]
    [Order(2)]
    public void Test1()
    {
        Assert.That(UniqueInOrderClass.UniqueInOrder("AAAABBBCCDAABBB"), Is.EqualTo("ABCDAB"));
    }
}
