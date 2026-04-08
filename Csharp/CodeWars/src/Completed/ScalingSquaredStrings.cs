namespace CodeWars.Completed;

public class ScalingSquaredStrings
{
    public static string Scale(string strng, int k, int n)
    {
        if (string.IsNullOrEmpty(strng) || k <= 0 || n <= 0)
            return string.Empty;

        var lines = strng.Split('\n');
        List<string> scaledLines = [];

        foreach (var line in lines)
        {
            var scaledLine = string.Concat(line.Select(c => new string(c, k)));
            for (int i = 0; i < n; i++)
                scaledLines.Add(scaledLine);
        }

        return string.Join('\n', scaledLines);
    }
}
