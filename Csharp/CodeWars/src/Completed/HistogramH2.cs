using System.Text;

namespace CodeWars.Completed;

public class HistogramH2
{
    public static string Histogram(int[] results)
    {
        var lines = new StringBuilder();
        int sum = results.Sum();

        for (int i = results.Length - 1; i >= 0; i--)
            lines.Append($"{i + 1}|{GenerateHash(results[i], sum)}");

        return lines.ToString();
    }

    private static string GenerateHash(int n, int sum)
    {
        if (sum == 0 || n == 0)
            return "\n";

        // percentage as integer (floor)
        int percentage = (int)Math.Floor((double)n / sum * 100);
        // scale so that 100% == 50 characters
        int barLength = (int)Math.Floor(percentage * 50.0 / 100.0);

        if (barLength > 0)
            return $"{new string('█', barLength)} {percentage}%\n";

        // if percentage > 0 but barLength == 0, still show percentage (no trailing spaces)
        return $" {percentage}%\n";
    }
}