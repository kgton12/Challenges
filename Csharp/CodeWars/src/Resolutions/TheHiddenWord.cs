namespace CodeWars.Resolutions;

public class TheHiddenWord
{
    public static readonly Dictionary<int, string> words = new() { { 6, "a" }, { 1, "b" }, { 7, "d" }, { 4, "e" }, { 3, "i" }, { 2, "l" }, { 9, "m" }, { 8, "n" }, { 0, "o" }, { 5, "t" } };
    public static string Hidden(int num) =>
        string.Concat(
            num.ToString()
               .Select(x => words.GetValueOrDefault((int)char.GetNumericValue(x)))
        );
}