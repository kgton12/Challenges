namespace CodeWars.Completed;

public class NameShufflerClass
{
    public static string NameShuffler(string str)
    {
        return string.Join(" ", str.Split(" ").Reverse());
    }
}

