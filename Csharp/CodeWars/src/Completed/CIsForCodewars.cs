using System.Text;

namespace CodeWars.Completed;

public class CIsForCodewars
{
    public static string GenerateC(int size)
    {
        StringBuilder sb = new();

        sb.Append(CreateLines(size));
        sb.Append(CreateColumns(size));
        sb.Append(CreateLines(size));

        return sb.ToString().Trim('\n');
    }

    private static string CreateColumns(int n)
    {
        var sb = new StringBuilder();
        for (int i = 0; i < n * 3; i++)
            sb.Append('C', n).Append('\n');
        return sb.ToString();
    }

    private static string CreateLines(int n)
    {
        var sb = new StringBuilder();
        for (int i = 0; i < n; i++)
            sb.Append('C', 5 * n).Append('\n');
        return sb.ToString();
    }
}