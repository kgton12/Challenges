namespace CodeWars.Completed;

public class ExclamationMarksSeries8MoveAllExclamationMarksToTheEndOfTheSentence
{
    public static string Remove(string s) =>
        new string(s).Replace("!", string.Empty) +
        new string('!', s.Count(x => x.Equals('!')));
}
