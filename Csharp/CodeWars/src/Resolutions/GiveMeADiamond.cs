using System.Text;

namespace CodeWars.Resolutions;

public class GiveMeADiamond
{
    public static string? Print(int n)
    {
        if (n % 2 == 0 || n < 1) return null;

        var result = new StringBuilder();
        int mid = n / 2;

        for (int i = 0; i <= mid; i++)
        {
            int stars = 2 * i + 1;
            int spaces = mid - i;
            result.Append(new string(' ', spaces));
            result.Append(new string('*', stars));
            result.Append('\n');
        }

        for (int i = mid - 1; i >= 0; i--)
        {
            int stars = 2 * i + 1;
            int spaces = mid - i;
            result.Append(new string(' ', spaces));
            result.Append(new string('*', stars));
            result.Append('\n');
        }

        return result.ToString();
    }
}
