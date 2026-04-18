using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class RiddleMadeCodeTwoSpiesTest
{
    [TestCase("6", "3")]
    [TestCase("12", "6")]
    [TestCase("10", "3")]
    [TestCase("1", "3")]
    [TestCase("15", "7")]
    [TestCase("13", "8")]
    public void TestAnswerByWordLength(string input, string expected)
    {
        Assert.That(RiddleMadeCodeTwoSpies.GetAnswer(input), Is.EqualTo(expected), "DEAD");
    }
}
