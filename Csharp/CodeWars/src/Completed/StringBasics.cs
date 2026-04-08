namespace CodeWars.Completed;

public class StringBasics
{
    public static string[] GetUserIds(string s)
    {
        List<string> result = [];

        foreach (var item in s.ToLower().Trim().Replace("#", "").Split(", "))
            result.Add(item[3..item.Length]);

        return [.. result];
    }
}