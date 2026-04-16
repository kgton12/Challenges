namespace CodeWars.Completed;

public class MakesTheSentenceClass
{
    public static bool MakesTheSentence(List<char> characters, string sentence)
    {
        List<char> sentenceList = [.. sentence.Replace(" ", string.Empty)];

        foreach (var item in characters)
            sentenceList.Remove(item);

        return sentenceList.Count <= 0;
    }
}