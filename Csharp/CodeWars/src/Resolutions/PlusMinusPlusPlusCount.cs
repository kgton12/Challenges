namespace CodeWars.src.Resolutions;

public class PlusMinusPlusPlusCount
{
    public static int CatchSignChange(int[] arr)
    {

        if (arr.Length == 0) return 0;

        bool isNegative = arr[0].ToString().Contains('-');
        int count = 0;

        foreach (var item in arr)
        {
            if (isNegative && item >= 0)
            {
                count++;
                isNegative = !isNegative;
            }

            if (!isNegative && item < 0)
            {
                count++;
                isNegative = !isNegative;
            }
        }
        return count;
    }
}
