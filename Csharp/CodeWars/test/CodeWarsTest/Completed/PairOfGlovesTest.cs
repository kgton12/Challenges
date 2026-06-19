using CodeWars.Completed;

namespace CodeWarsTest.Completed;

public class PairOfGlovesTest
{
    [Test]
    public void SampleTests()
    {
        Assertion(0, ["Green", "Blue", "Purple", "Gray"]);
        Assertion(0, []);
        Assertion(0, ["Purple"]);

        Assertion(1, ["Blue", "Purple", "Blue", "Gray", "Lime", "Black"]);
        Assertion(1, ["Blue", "Aqua", "Blue", "Teal", "Blue", "Black"]);

        Assertion(2, ["Blue", "Aqua", "Blue", "Brown", "Blue", "Orange", "Aqua"]);
    }

    private static void Assertion(int expected, string[] input) =>
      Assert.That(
        PairOfGloves.NumberOfPairs(input),
        Is.EqualTo(expected),
        $"Input: [{string.Join(", ", input)}]"
      );
}