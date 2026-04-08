using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class TidyNumberSpecialNumbersSeries9Test
{
    [Order(1)]
    [TestCase(12)]
    [TestCase(2789)]
    [TestCase(2335)]
    public void BasicTestsTrue(int n)
    {
        Assert.That(TidyNumberSpecialNumbersSeries9.TidyNumber(n), Is.True);
    }

    [Order(2)]
    [TestCase(102)]
    [TestCase(9672)]
    public void BasicTestsFalse(int n)
    {
        Assert.That(TidyNumberSpecialNumbersSeries9.TidyNumber(n), Is.False);
    }
}
