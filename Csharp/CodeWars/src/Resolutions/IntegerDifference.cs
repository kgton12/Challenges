namespace CodeWars.Resolutions;

public class IntegerDifference
{
    public static int IntDiff(int[] arr, int n)
    {
        var auxArr = arr.OrderByDescending(x => x).ToArray();
        int result = 0;
        for (int i = 0; i < auxArr.Length; i++)
        {
            for (int j = i; j < auxArr.Length; j++)
            {
                if (i != j)
                    result += auxArr[i] - auxArr[j] == n ? 1 : 0;
            }
        }

        return result;
    }
}