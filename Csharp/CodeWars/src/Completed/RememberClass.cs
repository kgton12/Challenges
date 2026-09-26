namespace CodeWars.Completed;

public class RememberClass
{
    public static List<char> Remember(string str)
    {
        var set = new HashSet<char>();
        return [.. str.Where(c => !set.Add(c)).Distinct()];
    }
}
