using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class EvenOrOddWhichIsGreaterTest
{
    [Test]
    [TestCase("123", "Odd is greater than Even")]
    [TestCase("12", "Even is greater than Odd")]
    [TestCase("112", "Even and Odd are the same")]
    public void BasicTests(string input, string expectedResult)
    {
        Assert.That(EvenOrOddWhichIsGreater.EvenOrOdd(input), Is.EqualTo(expectedResult));
    }
}
