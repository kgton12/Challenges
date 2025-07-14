namespace CodeWars.src.Resolutions;

public class FindTheFirstNonconsecutiveNumber
{
    public static object? FirstNonConsecutive(int[] arr)
    {
        for (int index = 0; index < arr.Length - 1; index++)
            if (arr[index + 1] - arr[index] != 1) return arr[index + 1];

        return null;
    }
}
