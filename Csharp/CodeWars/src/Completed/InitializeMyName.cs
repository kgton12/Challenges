namespace CodeWars.Completed;

public class InitializeMyName
{
    public static string InitializeNames(string name) =>
        string.Join(" ", name.Split().Select((value, index) => index != 0 && index != name.Split().Length - 1 ? AbbreviateName(value) : value));

    private static string AbbreviateName(string name) => $"{string.Concat(name.First()).ToUpper()}.";
}