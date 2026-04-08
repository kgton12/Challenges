namespace CodeWars.Completed;

public static class SumofOddCubedNumbers
{
    public static int CubeOdd(int[] arr)
    {
        return arr.Where(w => w % 2 != 0).Select(s => Convert.ToInt32(Math.Pow(s, 3))).Sum();
    }
}