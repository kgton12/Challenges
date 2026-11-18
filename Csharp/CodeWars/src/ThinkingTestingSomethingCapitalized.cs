namespace CodeWars;

public class ThinkingTestingSomethingCapitalized
{
    public string Testit(string s)
    {
        return string.Join(' ',
            s.Split(' ')
            .Select(LastLetterCapitalized)
        );
    }

    private string LastLetterCapitalized(string s)
    {
        return s.Length > 1 ?
            string.Concat(s[..^1]).ToLower() + char.ToUpper(s.Last()) :
            s.ToUpper();
    }
}