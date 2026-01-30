using CodeWars.Resolutions;

namespace CodeWarsTest.Completed;

public class FindNumbersWhichAreDivisibleByGivenNumberTest
{
    [TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, 2, ExpectedResult = new int[] { 2, 4, 6 })]
    public static int[] FixedTest(int[] numbers, int divisor)
    {
        return FindNumbersWhichAreDivisibleByGivenNumber.DivisibleBy(numbers, divisor);
    }
}
