using System.Text.RegularExpressions;

namespace CodeWars.Resolutions;

public class DotCalculator
{
    public static string Calculator(string txt)
    {
        string operatorChars = Regex.Replace(txt, "[.]", "").Trim();

        int[] values = [.. txt
            .Split(operatorChars)
            .Select(x =>
                x.Count(c =>
                    c.Equals('.')
                )
            )
        ];

        if (operatorChars.Equals("+"))
            return DotsFromInt(values[0] + values[1]);
        if (operatorChars.Equals("-"))
            return DotsFromInt(values[0] < values[1] ? 0 : values[0] - values[1]);
        if (operatorChars.Equals("*"))
            return DotsFromInt(values[0] * values[1]);
        if (operatorChars.Equals("//"))
            return DotsFromInt(Convert.ToInt32(values[0] < values[1] ? 0 : values[0] / values[1]));
        return string.Empty;
    }

    private static string DotsFromInt(int n) =>
        new('.', n);
}
