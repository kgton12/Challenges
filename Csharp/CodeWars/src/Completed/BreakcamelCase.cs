namespace CodeWars.Completed;

public static class BreakcamelCase
{
    public static string BreakCamelCase(string str) => string.Concat(str.Select(x => char.IsUpper(x) ? " " + x : x.ToString()));

    //whith REGEX
    //new Regex("([A-Z])").Replace(str, " $1");
}

