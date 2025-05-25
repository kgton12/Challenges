namespace BeeCrowd.src.Resolutions.Beginner;

public class Beecrowd1012
{
    public static void Area()
    {
        double A, B, C;
        A = Convert.ToDouble(Console.ReadLine());
        B = Convert.ToDouble(Console.ReadLine());
        C = Convert.ToDouble(Console.ReadLine());

        double quadrado = Math.Round(B * B, 3);
        double retangulo = Math.Round(A * B, 3);
        double trapezio = Math.Round((A + B) * C / 2, 3);
        double circulo = Math.Round(3.14159 * Math.Pow(C, 2), 3);
        double triangulo = Math.Round(A * C / 2, 3);


        Console.WriteLine($"TRIANGULO: {triangulo:f3}");
        Console.WriteLine($"CIRCULO: {circulo:f3}");
        Console.WriteLine($"TRAPEZIO: {trapezio:f3}");
        Console.WriteLine($"QUADRADO: {quadrado:f3}");
        Console.WriteLine($"RETANGULO: {retangulo:f3}");
    }
}
