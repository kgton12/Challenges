using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class GivenAnArrayOfNumbersWhichArePerfectSquaresTest
{
    [Test]
    public void SampleTests()
    {
        Assertion(expected: [1, 4, 9, 16], input: Range(1, 16));
        Assertion(expected: [1, 4, 9, 16, 25, 36, 49, 64, 81, 100], input: Range(1, 100));
        Assertion(expected: [1, 4, 16], input: [4, 1, 16, 1, 10, 35, 22]);
    }

    private static void Assertion(int[] expected, int[] input)
    {
        int[] actual = GivenAnArrayOfNumbersWhichArePerfectSquares.GetSquares((int[])input.Clone());

        Assert.That(actual, Is.Not.Null);
        Assert.That(actual, Is.EqualTo(expected),
          $"\n\n  Input: [{string.Join(", ", input)}]" +
          $"\n\n  Expected: [{string.Join(", ", expected)}]" +
          $"\n\n  Actual: [{string.Join(", ", actual)}]"
        );
    }

    private static int[] Range(int start, int end) =>
      [.. Enumerable.Range(start, end - start + 1)];
}