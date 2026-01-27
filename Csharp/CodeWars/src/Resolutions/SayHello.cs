namespace CodeWars.Resolutions;

public class SayHello
{
    public static string? Greet(string? name) =>
        string.IsNullOrEmpty(name)
        ? null
        : $"hello {name}!";
}
