namespace CodeWars.src.Resolutions;

public class VowelCount
{
    public static int GetVowelCount(string str) =>
        str.Count("aeiou".Contains);
}
