namespace CodeWars.Completed;

public class HighestScoringWord
{
    public static string High(string s) =>
            s.Split(' ')
             .Select((x, i) => new { Word = x, Sum = x.ToLower().Sum(x => x + 1 - 'a'), Index = i })
             .OrderByDescending(x => x.Sum)
             .ThenBy(x => x.Index)
             .First()
             .Word;
}