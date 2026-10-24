using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class AllUniqueTest
{
    [Test]
    public void TestHasUniqueChars1()
    {
        Assert.That(AllUnique.HasUniqueChars("abcdef"), Is.True);
    }

    [Test]
    public void TestHasUniqueChars2()
    {
        Assert.That(AllUnique.HasUniqueChars("++-"), Is.False);
    }

    [Test]
    public void TestHasUniqueChars3()
    {
        Assert.That(AllUnique.HasUniqueChars("  nAa"), Is.False);
    }

    [Test]
    public void TestHasUniqueChars4()
    {
        Assert.That(AllUnique.HasUniqueChars("aba"), Is.False);
    }
}
