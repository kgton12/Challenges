namespace CodeWars.Resolutions;

public class GreetMe
{
    public static string Greet(string name)
    {
        var nameFormatted = char.ToUpper(name[0]) + name[1..].ToLower();

        return $"Hello {nameFormatted}!";
    }
}

