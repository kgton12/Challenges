using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class PairsOfIntegersFromMToNTest
{
    [Test]
    public void ExampleTests()
    {
        Act(2, 4, [(2, 2), (2, 3), (2, 4), (3, 3), (3, 4), (4, 4)]);
        Act(0, 1, [(0, 0), (0, 1), (1, 1)]);
        Act(0, 0, [(0, 0)]);
    }

    private static void Act(int m, int n, (int, int)[] expected)
    {
        var msg = $"Invalid answer for m: {m}, n: {n}";
        var actual = PairsOfIntegersFromMToN.GeneratePairs(m, n).ToArray();
        Assert.That(Format(actual), Is.EqualTo(Format(expected)), msg);
    }

    private static string Format((int, int)[] xs) => string.Join(", ", xs);
}
