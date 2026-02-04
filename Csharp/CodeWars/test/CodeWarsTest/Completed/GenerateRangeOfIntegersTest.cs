using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class GenerateRangeOfIntegersTest
{
    [TestCase(2, 10, 2, ExpectedResult = new int[] { 2, 4, 6, 8, 10 })]
    public static int[] FixedTest(int min, int max, int step)
    {
        return GenerateRangeOfIntegers.GenerateRange(min, max, step);
    }
}
