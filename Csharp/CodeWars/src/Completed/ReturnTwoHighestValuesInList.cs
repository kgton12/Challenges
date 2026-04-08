namespace CodeWars.Completed;

public class ReturnTwoHighestValuesInList
{
    public static int[] TwoHighest(int[] arr) => [.. arr.Distinct().OrderByDescending(x => x).Take(2)];
}
