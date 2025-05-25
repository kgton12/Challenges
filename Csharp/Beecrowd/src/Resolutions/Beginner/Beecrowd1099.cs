namespace BeeCrowd.src.Resolutions.Beginner;

public class Beecrowd1099
{
    public static void SumOfConsecutiveOddNumbersII()
    {
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            int[] lineValues = (Console.ReadLine() ?? string.Empty)
                .Split(' ')
                .Select(value => Convert.ToInt32(value)).ToArray();

            int initial = Math.Min(lineValues[0], lineValues[1]);
            int final = Math.Max(lineValues[0], lineValues[1]);
            int sum = 0;

            for (int j = initial + 1; j < final; j++)
                sum += j % 2 != 0 ? j : 0;

            Console.WriteLine(sum);
        }
    }
}
