using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class SubstitutingVariablesIntoStringsPaddedNumbersTest
{
    [Test]
    public void BasicTest()
    {
        Assert.That(SubstitutingVariablesIntoStringsPaddedNumbers.Solution(5), Is.EqualTo("Value is 00005"));
    }
}
