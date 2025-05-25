using System.Text.RegularExpressions;

namespace CodeWars.src.Resolutions;

public class ExclamationMarksSeries6RemoveNExclamationMarksInTheSentenceFromLeftToRight
{
    public static string Remove(string s, int n)
    {
        return new Regex("!").Replace(s, "", n);
    }
}
