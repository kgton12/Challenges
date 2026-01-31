namespace CodeWars.Resolutions;

public static class MexicanWave
{
    public static List<string> Wave(string str)
    {
        List<string> result = [];

        for (int i = 0; i < str.Length; i++)
            if (!char.IsWhiteSpace(str[i])) result.Add(Upper(str, i));

        return result;

    }

    private static string Upper(string str, int index) =>
        string.Concat(str.Select((value, i) => i == index ? char.ToUpper(value) : value));
}
