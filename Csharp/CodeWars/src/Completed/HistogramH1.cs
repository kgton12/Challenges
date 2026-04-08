using System.Text;

namespace CodeWars.Completed;

public class HistogramH1
{
    public static string Histogram(int[] results)
    {
        var lines = new StringBuilder();

        for (int i = results.Length - 1; i >= 0; i--)
            lines.Append($"{i + 1}|{GenerateHash(results[i])}");

        return lines.ToString();
    }

    private static string GenerateHash(int n) =>
        n > 0
        ? $"{new string('#', n)} {n}\n"
        : "\n";
}
