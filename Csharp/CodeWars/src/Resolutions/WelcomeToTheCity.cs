namespace CodeWars.src.Resolutions;

public class WelcomeToTheCity
{
    public static string SayHello(string[] name, string city, string state) =>
        $"Hello, {string.Join(" ", name)}! Welcome to {city}, {state}!";
}
