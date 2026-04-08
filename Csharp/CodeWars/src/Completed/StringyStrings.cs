namespace CodeWars.Completed;

public class StringyStrings
{
    public static string Stringy(int size) =>
        string.Concat(Enumerable.Range(0, size).Select((_, index) => index % 2 == 0 ? "1" : "0"));
}
