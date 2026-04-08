using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class MultiplesOf3Or5Test
{
    [Test]
    public void SampleTests()
    {
        Assertion(expected: 23, input: 10);
        Assertion(expected: 78, input: 20);
        Assertion(expected: 9168, input: 200);
        Assertion(expected: 0, input: 0);
    }

    private static void Assertion(int expected, int input) =>
      Assert.That(
        MultiplesOf3Or5.Solution(input),
        Is.EqualTo(expected),
        $"Incorrect answer for input={input}"
      );
}
