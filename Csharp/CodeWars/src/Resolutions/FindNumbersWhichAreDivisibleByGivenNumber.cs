namespace CodeWars.src.Resolutions;

public class FindNumbersWhichAreDivisibleByGivenNumber
{
    public static int[] DivisibleBy(int[] numbers, int divisor) =>
        [.. numbers.Where(x => x % divisor == 0)];
}
