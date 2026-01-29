using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class ParseNiceIntFromCharProblemTest
{
    [Test]
    public void BasicTests()
    {
        using (Assert.EnterMultipleScope())
        {
            Assert.That(ParseNiceIntFromCharProblem.GetAge("3 years old"), Is.EqualTo(3));
            Assert.That(ParseNiceIntFromCharProblem.GetAge("4 years old"), Is.EqualTo(4));
            Assert.That(ParseNiceIntFromCharProblem.GetAge("9 years old"), Is.EqualTo(9));
        }
    }
}
