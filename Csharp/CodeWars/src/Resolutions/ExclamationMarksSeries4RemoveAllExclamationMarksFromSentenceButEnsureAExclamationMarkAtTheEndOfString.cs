namespace CodeWars.src.Resolutions;

public class ExclamationMarksSeries4RemoveAllExclamationMarksFromSentenceButEnsureAExclamationMarkAtTheEndOfString
{
    public static string Remove(string s) =>
         $"{s.Replace("!", "")}!";
}
