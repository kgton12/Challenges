namespace BeeCrowd.src.Resolutions.Beginner;

public class Beecrowd1010
{
    public static void SimpleCalculation()
    {
        double sum = 0;

        for (int i = 0; i < 2; i++)
        {
            string inputLine = Console.ReadLine() ?? string.Empty;

            string[] parts = inputLine.Split(' ');

            string _ = parts[0];
            int quantity = Convert.ToInt32(parts[1]);
            double value = Convert.ToDouble(parts[2]);

            sum += quantity * value;
        }

        Console.WriteLine($"VALOR A PAGAR: R$ {sum:F2}");
    }
}
