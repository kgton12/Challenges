namespace CodeWars.src.Resolutions;

public class SplitStrings
{
    public static string[] Solution(string str)
    {
        if (str.Length % 2 != 0) str += "_";

        List<string> result = [];

        for (int i = 0; i < str.Length; i += 2)
            result.Add(str.Substring(i, 2));

        return [.. result];
    }
}
