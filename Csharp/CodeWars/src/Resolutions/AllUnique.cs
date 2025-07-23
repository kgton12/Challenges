namespace CodeWars.src.Resolutions;

public class AllUnique
{
    public static bool HasUniqueChars(string str) =>
        str.Length == str.Distinct().Count();
}
