namespace CodeWars.Completed;

public class TwoSumClass
{
    public static int[] TwoSum(int[] numbers, int target)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[i] + numbers[j] == target)
                    return [i, j];
            }
        }

        return [];
    }
}
