namespace CodeWars.Completed;

public static class AverageArray
{
    public static double[] AvgArray(double[][] arr)
    {
        double[] result = new double[arr[0].Length];

        for (int i = 0; i < arr.Length; i++)
            for (int j = 0; j < arr[i].Length; j++)
                result[j] += arr[i][j];

        return [.. result.Select(x => x / arr.Length)];
    }
}
