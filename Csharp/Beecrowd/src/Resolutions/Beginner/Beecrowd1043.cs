namespace BeeCrowd.src.Resolutions.Beginner;

public class Beecrowd1043
{
    public static void Triangle()
    {
        double A, B, C, calculatedArea, calculatedPerimeter;

        string[] inputLine = (Console.ReadLine() ?? string.Empty).Split(' ');

        A = Convert.ToDouble(inputLine[0]);
        B = Convert.ToDouble(inputLine[1]);
        C = Convert.ToDouble(inputLine[2]);

        calculatedPerimeter = A + B + C;
        calculatedArea = ((A + B) * C) / 2;

        if (B - C < A && B - C < B + C && A - C < B && A - C < A + C && A - B < C && A - B < A + B)
            Console.WriteLine($"Perimetro = {calculatedPerimeter:F!}");
        else
            Console.WriteLine($"Area = {calculatedArea:F1}");
    }
}
