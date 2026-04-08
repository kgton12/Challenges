namespace CodeWars.Completed;

public class VowelCount
{
    public static int GetVowelCount(string str) =>
        str.Count("aeiou".Contains);
}
