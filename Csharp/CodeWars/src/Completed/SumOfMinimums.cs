namespace CodeWars.Completed;

public static class SumOfMinimumsClass
{
    public static int SumOfMinimums(int[,] numbers)
    {
        int sum = 0;

        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            int minimums = int.MaxValue;

            for (int j = 0; j < numbers.GetLength(1); j++)
                minimums = numbers[i, j] < minimums ? numbers[i, j] : minimums;

            sum += minimums;

        }

        return sum;
    }
}

