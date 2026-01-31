using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class ArrayLeadersArraySeries3Test
{
    [Test, Description("Positive Values")]
    [Order(1)]
    [TestCase(new int[] { 1, 2, 3, 4, 0 }, ExpectedResult = new int[] { 4 })]
    [TestCase(new int[] { 16, 17, 4, 3, 5, 2 }, ExpectedResult = new int[] { 17, 5, 2 })]
    public int[] PositiveTests(int[] numbers)
    {
        return ArrayLeadersArraySeries3.ArrayLeaders(numbers);
    }

    [Test, Description("Negative Values")]
    [Order(2)]
    [TestCase(new int[] { -1, -29, -26, -2 }, ExpectedResult = new int[] { -1 })]
    [TestCase(new int[] { -36, -12, -27 }, ExpectedResult = new int[] { -36, -12 })]
    public int[] NegativeTests(int[] numbers)
    {
        return ArrayLeadersArraySeries3.ArrayLeaders(numbers);
    }

    [Test, Description("Mixed Values")]
    [Order(3)]
    [TestCase(new int[] { 5, -2, 2 }, ExpectedResult = new int[] { 5, 2 })]
    [TestCase(new int[] { 0, -1, -29, 3, 2 }, ExpectedResult = new int[] { 0, -1, 3, 2 })]
    public int[] MixedTests(int[] numbers)
    {
        return ArrayLeadersArraySeries3.ArrayLeaders(numbers);
    }
}
