namespace CodeWars.Completed;

public class HighestAndLowest
{
    public static string HighAndLow(string numbers)
    {
        int[] values = [.. numbers.Split(" ").Select(int.Parse)];
        return $"{values.Max()} {values.Min()}";
    }
}
