namespace CodeWars.src.Resolutions;

public class SmallestValueOfAnArray
{
    public static int FindSmallest(int[] numbers, string mode)
    {
        int minValue = numbers.Min();

        return mode == "index" ? Array.IndexOf(numbers, minValue) : minValue;
    }
}
