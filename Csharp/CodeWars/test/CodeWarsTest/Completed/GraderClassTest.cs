using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class GraderClassTest
{
    [Test]
    [TestCase(0.7, ExpectedResult = 'C')]
    [TestCase(0.9, ExpectedResult = 'A')]
    [TestCase(0.6, ExpectedResult = 'D')]
    public static char FixedTest(double score)
    {
        return GraderClass.Grader(score);
    }
}
