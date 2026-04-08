namespace CodeWars.Completed;

public class FilteringEvenNumbersBugFixes
{
    public static List<int> FilterOddNumber(List<int> listOfNumbers) =>
        [.. listOfNumbers.Where(x => x % 2 != 0)];
}