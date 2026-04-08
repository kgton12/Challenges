using static CodeWars.Completed.RockPaperScissorsLizardSpock;

namespace CodeWarsTest.Completed;

public class RockPaperScissorsLizardSpockTest
{
    [TestCase(Value.Rock, Value.Lizard, Ordering.GT)]
    [TestCase(Value.Paper, Value.Rock, Ordering.GT)]
    [TestCase(Value.Scissors, Value.Lizard, Ordering.GT)]
    [TestCase(Value.Lizard, Value.Paper, Ordering.GT)]
    [TestCase(Value.Spock, Value.Rock, Ordering.GT)]
    public void Player1Wins(Value a, Value b, Ordering expected)
    {
        Act(a, b, expected);
    }

    [TestCase(Value.Rock, Value.Lizard, Ordering.LT)]
    [TestCase(Value.Paper, Value.Rock, Ordering.LT)]
    [TestCase(Value.Scissors, Value.Lizard, Ordering.LT)]
    [TestCase(Value.Lizard, Value.Paper, Ordering.LT)]
    [TestCase(Value.Spock, Value.Rock, Ordering.LT)]
    public void Player2Wins(Value a, Value b, Ordering expected)
    {
        // note that a and b are swapped
        Act(b, a, expected);
    }

    [TestCase(Value.Rock, Value.Rock, Ordering.EQ)]
    [TestCase(Value.Spock, Value.Spock, Ordering.EQ)]
    public void Draw(Value a, Value b, Ordering expected)
    {
        Act(a, b, expected);
    }

    private static void Act(Value a, Value b, Ordering expected)
    {
        var msg = $"Invalid answer for a: {a}, b = {b}";
        var actual = Rpsls(a, b);
        Assert.That(actual, Is.EqualTo(expected), msg);
    }
}
