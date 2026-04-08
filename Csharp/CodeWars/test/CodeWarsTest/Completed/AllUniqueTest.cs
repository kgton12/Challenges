using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class AllUniqueTest
{
    [Test, Order(1)]
    public void TestHasUniqueChars1()
    {
        Assert.That(AllUnique.HasUniqueChars("abcdef"), Is.True);
    }

    [Test, Order(2)]
    public void TestHasUniqueChars2()
    {
        Assert.That(AllUnique.HasUniqueChars("++-"), Is.False);
    }

    [Test, Order(3)]
    public void TestHasUniqueChars3()
    {
        Assert.That(AllUnique.HasUniqueChars("  nAa"), Is.False);
    }

    [Test, Order(4)]
    public void TestHasUniqueChars4()
    {
        Assert.That(AllUnique.HasUniqueChars("aba"), Is.False);
    }
}
