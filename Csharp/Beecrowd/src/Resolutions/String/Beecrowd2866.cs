using System.Text.RegularExpressions;

namespace BeeCrowd.src.Resolutions.String;

public class Beecrowd2866
{
    public static void Cryptotext()
    {
        int N = Convert.ToInt32(Console.ReadLine());
        Regex pattern = new Regex("[A-Z]");

        for (int i = 0; i < N; i++)
        {
            string lineValue = Console.ReadLine() ?? string.Empty;

            Console.WriteLine(string.Concat(pattern.Replace(lineValue, "").Reverse()));
        }
    }
}
