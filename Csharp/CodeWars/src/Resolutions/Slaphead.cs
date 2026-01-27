namespace CodeWars.Resolutions;

public class Slaphead
{
    public static string[] Bald(string x)
    {
        int count = x.Count(c => c.Equals('/'));
        List<string> result = [];

        result.Add(x.Replace("/", "-"));

        if (count == 0)
            result.Add("Clean!");
        else if (count == 1)
            result.Add("Unicorn!");
        else if (count == 2)
            result.Add("Homer!");
        else if (count >= 3 && count <= 5)
            result.Add("Careless!");
        else
            result.Add("Hobo!");

        return [.. result];
    }
}