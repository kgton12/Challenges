namespace CodeWars.Resolutions;

public class EqualSidesOfAnArray
{
    public static int FindEvenIndex(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
            if (CalculateArrayElements(arr, i)) return i;

        return -1;
    }

    private static bool CalculateArrayElements(int[] arr, int i)
    {
        var initialPart = arr[0..i].Sum();
        var finalPart = arr.Skip(i + 1).Sum();

        return initialPart == finalPart;
    }
}