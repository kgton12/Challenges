namespace CodeWars.src.Resolutions;

public class ComfortableWords
{
    public static bool ComfortableWord(string word)
    {
        string result = string.Concat(word.Select(x => "yuiophjklnm".Contains(x) ? 'R' : 'L'));

        return !result.Contains("RR") && !result.Contains("LL");
    }
}
