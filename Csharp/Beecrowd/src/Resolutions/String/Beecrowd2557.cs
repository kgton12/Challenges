using System.Text.RegularExpressions;

namespace BeeCrowd.src.Resolutions.String;

internal class Beecrowd2557
{
    public static void RLJ()
    {
        while (true)
        {
            string lineValue = Console.ReadLine() ?? string.Empty;

            if (string.IsNullOrEmpty(lineValue.Trim())) break;

            Console.WriteLine(RuleOfThree(lineValue));
        }
    }

    private static int RuleOfThree(string str)
    {
        var regex = new Regex("[+=]");
        string[] values = regex.Replace(str, " ").Split(' ').ToArray();

        string R = values[0];
        string L = values[1];
        string J = values[2];

        if (str.Contains('R')) return Convert.ToInt32(J) - Convert.ToInt32(L);
        else if (str.Contains('L')) return Convert.ToInt32(J) - Convert.ToInt32(R);
        else return Convert.ToInt32(R) + Convert.ToInt32(L);
    }
}
