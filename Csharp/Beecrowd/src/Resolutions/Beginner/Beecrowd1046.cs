namespace BeeCrowd.src.Resolutions.Beginner;

public class Beecrowd1046
{
    public static void GameTime()
    {
        double A, B;
        string[] inputValues = (Console.ReadLine() ?? string.Empty).Split(' ');

        A = Convert.ToDouble(inputValues[0]);
        B = Convert.ToDouble(inputValues[1]);

        if (A == B)
            Console.WriteLine("O JOGO DUROU 24 HORA(S)");
        else if (A > B)
        {
            double result = 24 - A;
            result += B;
            Console.WriteLine($"O JOGO DUROU {result} HORA(S)");
        }
        else if (A < B)
            Console.WriteLine($"O JOGO DUROU {B - A} HORA(S)");
    }
}
