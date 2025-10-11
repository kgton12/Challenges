namespace CodeWars.src.Resolutions;

public class MoveAllVowels
{
    public static string MoveVowel(string input) =>
        string.Concat(input.Where(x => !"aeiou".Contains(x))
                .Concat(input.Where("aeiou".Contains)));
}