using System.Globalization;

namespace BeeCrowd.src.Resolutions.Beginner;

public class Beecrowd1036
{
    public static void BhaskarasFormula()
    {
        double A, B, C, T;
        string[] inputValues = (Console.ReadLine() ?? "").Split(' ');

        A = Convert.ToDouble(inputValues[0], CultureInfo.InvariantCulture);
        B = Convert.ToDouble(inputValues[1], CultureInfo.InvariantCulture);
        C = Convert.ToDouble(inputValues[2], CultureInfo.InvariantCulture);

        if (((B * B) - 4 * A * C) < 0 || A == 0)
            Console.WriteLine("Impossivel calcular");
        else
        {
            T = Math.Sqrt((B * B) - 4 * A * C);
            Console.WriteLine($"R1 = {((-B + T) / (2 * A)):f5}");
            Console.WriteLine($"R2 = {((-B - T) / (2 * A)):f5}");
        }
    }
}
