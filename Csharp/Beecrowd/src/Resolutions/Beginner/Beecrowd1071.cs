namespace BeeCrowd.src.Resolutions.Beginner;

public class Beecrowd1071
{
    public static void SumofConsecutiveOddsI()
    {
        int[] inputNumbers = new int[2];
        int sumOfConsecutiveOdds = 0;

        for (int i = 0; i < 2; i++)
            inputNumbers[i] = Convert.ToInt32(Console.ReadLine());

        for (int i = inputNumbers.Min() + 1; i < inputNumbers.Max(); i++)
            if (i % 2 != 0)
                sumOfConsecutiveOdds += i;

        Console.WriteLine(sumOfConsecutiveOdds);
    }
}
