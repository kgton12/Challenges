namespace CodeWars.Completed;

public class SayHello
{
    public static string? Greet(string? name) =>
        string.IsNullOrEmpty(name)
        ? null
        : $"hello {name}!";
}
