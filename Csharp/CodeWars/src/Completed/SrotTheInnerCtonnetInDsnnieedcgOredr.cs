namespace CodeWars.Completed;

public class SrotTheInnerCtonnetInDsnnieedcgOredr
{
    public static string SortTheInnerContent(string words)
    {
        return string.Join(' ',
            words.Split(' ')
            .Select(ReverseTheMiddleOfTheWord)
        );
    }

    private static string ReverseTheMiddleOfTheWord(string str)
    {
        if (str.Length <= 3)
            return str;

        char firstChar = str.First();
        string middle = string.Concat(str[1..^1].OrderByDescending(x => x));
        char lastChar = str.Last();

        return string.Concat(
            firstChar,
            middle,
            lastChar
        );
    }
}