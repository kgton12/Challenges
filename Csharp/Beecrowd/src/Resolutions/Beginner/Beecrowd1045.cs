namespace BeeCrowd.src.Resolutions.Beginner;

public class Beecrowd1045
{
    public static void TypesOfTriangles()
    {
        double A, B, C;
        string[] inputValues = (Console.ReadLine() ?? string.Empty).Split(' ');

        A = Convert.ToDouble(inputValues[0]);
        B = Convert.ToDouble(inputValues[1]);
        C = Convert.ToDouble(inputValues[2]);

        if (A >= (B + C) || B >= (A + C) || C >= (A + B))
            Console.WriteLine("NAO FORMA TRIANGULO");
        else if (A * A == (B * B + C * C) || B * B == (A * A + C * C) || C * C == (A * A + B * B))
            Console.WriteLine("TRIANGULO RETANGULO");
        else if (A * A > (B * B + C * C) || B * B > (A * A + C * C) || C * C > (A * A + B * B))
            Console.WriteLine("TRIANGULO OBTUSANGULO");
        else if (A * A < (B * B + C * C) || B * B < (A * A + C * C) || C * C < (A * A + B * B))
            Console.WriteLine("TRIANGULO ACUTANGULO");
        if (A == B && A == C)
            Console.WriteLine("TRIANGULO EQUILATERO");
        if ((A == B && A != C) || (A == C && A != B) || (B == C && B != A))
            Console.WriteLine("TRIANGULO ISOSCELES");
    }
}
