namespace CodeWars.Resolutions;

public static class RemoveFirstandLastCharacterPartTwo
{
    public static string? Array(string s)
    {
        if (s.Split(',').Length < 3) return null;

        var elements = s.Split(",");

        return string.Join(" ", elements.Skip(1).Take(elements.Length - 2).ToArray());
    }
}

