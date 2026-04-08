using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class RockPaperScissorsTest
{
    [Test]
    [Order(1)]
    public void Player1Win()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(RockPaperScissors.Rps("rock", "scissors"), Is.EqualTo("Player 1 won!"));
            Assert.That(RockPaperScissors.Rps("scissors", "paper"), Is.EqualTo("Player 1 won!"));
            Assert.That(RockPaperScissors.Rps("paper", "rock"), Is.EqualTo("Player 1 won!"));
        }
    }

    [Test]
    [Order(2)]
    public void Player2Win()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(RockPaperScissors.Rps("scissors", "rock"), Is.EqualTo("Player 2 won!"));
            Assert.That(RockPaperScissors.Rps("paper", "scissors"), Is.EqualTo("Player 2 won!"));
            Assert.That(RockPaperScissors.Rps("rock", "paper"), Is.EqualTo("Player 2 won!"));
        }
    }

    [Test]
    [Order(3)]
    public void Draw()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(RockPaperScissors.Rps("rock", "rock"), Is.EqualTo("Draw!"));
            Assert.That(RockPaperScissors.Rps("scissors", "scissors"), Is.EqualTo("Draw!"));
            Assert.That(RockPaperScissors.Rps("paper", "paper"), Is.EqualTo("Draw!"));
        }
    }
}
