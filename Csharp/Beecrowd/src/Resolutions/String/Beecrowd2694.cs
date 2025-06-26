using System.Text.RegularExpressions;

namespace BeeCrowd.src.Resolutions.String;

public class Beecrowd2694
{
    public static void CalculatorProblem()
    {
        int N = Convert.ToInt32(Console.ReadLine());
        Regex pattern = new Regex("[a-zA-Z]");

        for (int i = 0; i < N; i++)
        {
            var lineValue = pattern.Replace(Console.ReadLine() ?? string.Empty, " ").Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(lineValue.Sum(int.Parse));
        }
    }
}

