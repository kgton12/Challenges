using System.Text.RegularExpressions;

namespace BeeCrowd.src.Resolutions.String;

public class Beecrowd1551
{
    public static void CompleteSentence()
    {
        int N = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            string lineValue = Console.ReadLine() ?? string.Empty;
            var uniqueDigitCount = Regex.Replace(lineValue, "[^a-zA-Z]", "").Distinct().ToArray().Length;

            if (uniqueDigitCount == 26)
                Console.WriteLine("frase completa");
            else if (uniqueDigitCount >= 13)
                Console.WriteLine("frase quase completa");
            else
                Console.WriteLine("frase mal elaborada");
        }
    }
}
