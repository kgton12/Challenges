namespace CodeWars.src.Resolutions;

public class WeirdWords
{
    public static string NextLetter(string str) =>
        string.Concat(str.Select(x =>
        {
            if (x.Equals('z') || x.Equals('Z'))
                return char.IsUpper(x) ? 'A' : 'a';

            return char.IsLetter(x) ? Convert.ToChar(x + 1) : x;
        }));
}