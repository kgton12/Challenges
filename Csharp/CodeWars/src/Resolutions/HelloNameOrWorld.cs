using System.Globalization;

namespace CodeWars.Resolutions;

public class HelloNameOrWorld
{
    public static string Hello(string name = "") =>
        string.IsNullOrEmpty(name)
            ? "Hello, World!"
            : $"Hello, {CultureInfo.CurrentCulture.TextInfo.ToTitleCase(name.ToLower())}!";
}
