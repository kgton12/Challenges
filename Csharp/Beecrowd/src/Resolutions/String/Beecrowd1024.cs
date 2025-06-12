using System.Text.RegularExpressions;

namespace BeeCrowd.src.Resolutions.String;

public class Beecrowd1024
{
    public static void Cryptography()
    {
        int N = Convert.ToInt32(Console.ReadLine());
        List<string> lineValues = new List<string>();
        List<string> result = new List<string>();

        for (int i = 0; i < N; i++)
            lineValues.Add(Console.ReadLine() ?? string.Empty);

        foreach (var item in lineValues)
        {
            string firstPass = Regex.Replace(item, "[A-Za-z]", x =>
                    MoveThreePositionsAsciiTable(Convert.ToChar(x.Value)).ToString());

            string invertedLine = new string(firstPass.Reverse().ToArray());

            int mid = invertedLine.Length / 2;
            char[] chars = invertedLine.ToCharArray();

            for (int i = mid; i < chars.Length; i++)
                chars[i] = ReturnOnePositionAsciiTable(chars[i]);

            string finalLine = new string(chars);
            result.Add(finalLine);
        }

        foreach (var res in result)
            Console.WriteLine(res);
    }

    private static char MoveThreePositionsAsciiTable(char c) => Convert.ToChar(c + 3);

    private static char ReturnOnePositionAsciiTable(char c) => Convert.ToChar(c - 1);
}