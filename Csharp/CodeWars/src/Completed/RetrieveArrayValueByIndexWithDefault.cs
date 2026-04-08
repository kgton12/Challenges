namespace CodeWars.Completed;

public class RetrieveArrayValueByIndexWithDefault
{
    public static int Solution(int[] items, int index, int defaultValue)
    {
        if (Math.Abs(index) > items.Length)
            return defaultValue;

        if (index > 0)
            return items[index];
        else
            return items.Reverse().ToArray()[Math.Abs(index + 1)];
    }
}
