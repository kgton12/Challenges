namespace BeeCrowd.src.Resolutions.Beginner;

public class Beecrowd1066
{
    public static void EvenOddPositiveAndNegative()
    {
        int evenCount = 0;
        int oddCount = 0;
        int positiveCount = 0;
        int negativeCount = 0;

        for (int i = 0; i < 5; i++)
        {
            int value = Convert.ToInt32(Console.ReadLine());

            if (value % 2 == 0) evenCount++;
            else oddCount++;

            if (value > 0) positiveCount++;
            else if (value < 0) negativeCount++;
        }

        Console.WriteLine($"{evenCount} valor(es) par(es)");
        Console.WriteLine($"{oddCount} valor(es) impar(es)");
        Console.WriteLine($"{positiveCount} valor(es) positivo(s)");
        Console.WriteLine($"{negativeCount} valor(es) negativo(s)");
    }
}
