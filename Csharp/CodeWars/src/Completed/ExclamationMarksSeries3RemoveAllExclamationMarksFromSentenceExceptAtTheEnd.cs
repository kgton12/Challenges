namespace CodeWars.Completed;

public class ExclamationMarksSeries3RemoveAllExclamationMarksFromSentenceExceptAtTheEnd
{
    public static string Remove(string s)
    {
        int questionMarksAtEnd = GetQuestionMarksAtEnd(s);

        return s.Replace("!", string.Empty) + new string('!', questionMarksAtEnd);
    }

    private static int GetQuestionMarksAtEnd(string str)
    {
        string reversedString = string.Concat(str.Reverse());

        for (int i = 0; i < reversedString.Length; i++)
        {
            if (reversedString[i] != '!') return i;
        }
        return 0;
    }
}
