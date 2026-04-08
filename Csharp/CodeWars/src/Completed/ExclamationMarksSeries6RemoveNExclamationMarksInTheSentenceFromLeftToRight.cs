using System.Text.RegularExpressions;

namespace CodeWars.Completed;

public class ExclamationMarksSeries6RemoveNExclamationMarksInTheSentenceFromLeftToRight
{
    public static string Remove(string s, int n)
    {
        return new Regex("!").Replace(s, "", n);
    }
}
