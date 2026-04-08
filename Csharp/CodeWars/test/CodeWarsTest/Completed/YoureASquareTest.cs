using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class YoureASquareTest
{
    [Test, Order(1)]
    public static void ShouldWorkForSomeExamples()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(YoureASquare.IsSquare(-1), Is.False, "negative numbers aren't square numbers");
            Assert.That(YoureASquare.IsSquare(3), Is.False, "3 isn't a square number");
            Assert.That(YoureASquare.IsSquare(4), Is.True, "4 is a square number");
            Assert.That(YoureASquare.IsSquare(25), Is.True, "25 is a square number");
            Assert.That(YoureASquare.IsSquare(26), Is.False, "26 isn't a square number");
        }
    }
}
