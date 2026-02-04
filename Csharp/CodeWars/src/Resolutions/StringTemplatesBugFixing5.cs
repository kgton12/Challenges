namespace CodeWars.Resolutions;

public class StringTemplatesBugFixing5
{
    public static string BuildString(string[] args) =>
        $"I like {string.Join(", ", args)}!";
}
