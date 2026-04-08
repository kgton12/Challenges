namespace CodeWars.Completed;

public class NotAllButSometimesAll
{
    public static string Remove(string str, Dictionary<char, int> what)
    {
        List<char> newString = [.. str];

        foreach (var item in what)
        {
            for (int i = 0; i < item.Value; i++)
                newString.Remove(item.Key);
        }

        return string.Concat(newString);
    }
}