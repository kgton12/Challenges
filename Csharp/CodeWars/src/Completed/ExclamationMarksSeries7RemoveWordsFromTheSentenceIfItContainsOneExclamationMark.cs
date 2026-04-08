namespace CodeWars.Completed;

public class ExclamationMarksSeries7RemoveWordsFromTheSentenceIfItContainsOneExclamationMark
{
    public static string Remove(string s) =>
        string.Join(" ",
            s
            .Split(" ")
            .Where(x => x.Count(c => c.Equals('!')) != 1));
}
